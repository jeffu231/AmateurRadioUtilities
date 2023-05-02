using System.Xml.Serialization;
using CoreServices.Model.Qrz;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Net.Http.Headers;

namespace CoreServices.Services;

public class QrzDataService
{
    private readonly string _username;
    private readonly string _password;
    private static string _sessionToken = String.Empty;
    private readonly HttpClient _httpClient;
    private readonly ILogger<QrzDataService> _logger;

    public QrzDataService(HttpClient httpClient, ILogger<QrzDataService> logger)
    {
        _logger = logger;
        _username = Environment.GetEnvironmentVariable("username") ?? String.Empty;
        _password = Environment.GetEnvironmentVariable("password") ?? String.Empty;
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("https://xmldata.qrz.com");
        _httpClient.DefaultRequestHeaders.Add(HeaderNames.UserAgent, "Mozilla/5.0");
    }

    private async Task<Tuple<bool,QRZDatabase>> CreateSessionAsync()
    {
        _logger.LogDebug("Creating session token");
        var query = new Dictionary<string, string>
        {
            ["username"] = _username,
            ["password"] = _password,
            ["agent"] = "ARUv1.0"
        };

        try
        {
            HttpContent content = new FormUrlEncodedContent(query);
            var response = await _httpClient.PostAsync("/xml/current", content);

            var xml = await response.Content.ReadAsStringAsync();
            _logger.LogDebug(xml);
        
            XmlSerializer serializer = new XmlSerializer(typeof(QRZDatabase));

            using StringReader reader = new StringReader(xml);
            if (serializer.Deserialize(reader) is QRZDatabase qrzDatabase)
            {
                if(qrzDatabase.Session != null && qrzDatabase.Session[0].Key != null)
                {
                    _sessionToken = qrzDatabase.Session[0].Key;
                    return Tuple.Create(true, qrzDatabase);
                }
                _sessionToken = string.Empty;
                return Tuple.Create(false, qrzDatabase);
            }
            
            _logger.LogError(@"Failed create session for QRZ");
            return Tuple.Create(false, CreateError("Error deserializing session", string.Empty));
        }
        catch (Exception ex)
        {
            _logger.LogError(@"Failed create session for QRZ");
            return Tuple.Create(false, CreateError("Error creating session", ex.Message));
        }
    }

    public async Task<QRZDatabase> GetCallDataAsync(string call)
    {
        if (_sessionToken == String.Empty)
        {
            var status = await CreateSessionAsync();
            if (status.Item1 == false)
            {
                _logger.LogError("Failed to create QRZ session");
                return status.Item2;
            }
        }

        var tryCount = 0;

        while (true)
        {
            tryCount++;
            var keys = new Dictionary<string, string?>
            {
                ["s"] = _sessionToken,
                ["callsign"] = call
            };
            try
            {
                var response = await _httpClient.GetAsync(QueryHelpers.AddQueryString("/xml/current", keys));
               
                var xml = await response.Content.ReadAsStringAsync();
                _logger.LogDebug(xml);
                
                XmlSerializer serializer = new XmlSerializer(typeof(QRZDatabase));

                using StringReader reader = new StringReader(xml);
                if (serializer.Deserialize(reader) is QRZDatabase qrzDatabase)
                {
                    if (qrzDatabase.Session != null)
                    {
                        if (!string.IsNullOrEmpty(qrzDatabase.Session[0].Key))
                        {
                            //We got a good response since the key is populated.
                            return qrzDatabase;
                        }
                        //Session is probably expired, so recreate it and try once again.
                        _sessionToken = String.Empty;
                        if (tryCount < 2)
                        {
                            await CreateSessionAsync();
                            continue;
                        }
                        return qrzDatabase;
                    }
                }
               
                _logger.LogError(@"Failed to deserialize response from QRZ call search");
                return CreateError("Call lookup failed.", @"Failed to deserialize response from QRZ call search" );
            }
            catch (Exception ex)
            {
                _logger.LogError(ex,@"Error calling QRZ call search");
                return CreateError("Error calling QRZ call search", ex.Message);
            }
        }
    }

    private QRZDatabase CreateError(string error, string message)
    {
        return new QRZDatabase
        {
            Session = new[] { new QRZDatabaseSession { Error = error, Message = message} }
        };
    }
}