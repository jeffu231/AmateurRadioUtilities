//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
//This source code was auto-generated by MonoXSD
//

using Newtonsoft.Json;

namespace CoreServices.Model.Qrz {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://xmldata.qrz.com")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://xmldata.qrz.com", IsNullable=false)]
    public partial class QRZDatabase {
        
        private QRZDatabaseCallsign[] callsignField;
        
        private QRZDatabaseSession[] sessionField;
        
        private string versionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Callsign")]
        public QRZDatabaseCallsign[] Callsign {
            get {
                return this.callsignField;
            }
            set {
                this.callsignField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Session")]
        public QRZDatabaseSession[] Session {
            get {
                return this.sessionField;
            }
            set {
                this.sessionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://xmldata.qrz.com")]
    public partial class QRZDatabaseCallsign {
        
        private string callField;
        
        private string aliasesField;
        
        private string dxccField;
        
        private string fnameField;
        
        private string nameField;
        
        private string addr1Field;
        
        private string addr2Field;
        
        private string stateField;
        
        private string zipField;
        
        private string countryField;
        
        private string latField;
        
        private string lonField;
        
        private string gridField;
        
        private string countyField;
        
        private string ccodeField;
        
        private string fipsField;
        
        private string landField;
        
        private string efdateField;
        
        private string expdateField;
        
        private string classField;
        
        private string codesField;
        
        private string qslmgrField;
        
        private string emailField;
        
        private string u_viewsField;
        
        private string bioField;
        
        private string biodateField;
        
        private string moddateField;
        
        private string mSAField;
        
        private string areaCodeField;
        
        private string timeZoneField;
        
        private string gMTOffsetField;
        
        private string dSTField;
        
        private string eqslField;
        
        private string mqslField;
        
        private string cqzoneField;
        
        private string ituzoneField;
        
        private string lotwField;
        
        private string geolocField;
        
        private string name_fmtField;
        
        /// <remarks/>
        public string call {
            get {
                return this.callField;
            }
            set {
                this.callField = value;
            }
        }
        
        /// <remarks/>
        public string aliases {
            get {
                return this.aliasesField;
            }
            set {
                this.aliasesField = value;
            }
        }
        
        /// <remarks/>
        public string dxcc {
            get {
                return this.dxccField;
            }
            set {
                this.dxccField = value;
            }
        }
        
        /// <remarks/>
        public string fname {
            get {
                return this.fnameField;
            }
            set {
                this.fnameField = value;
            }
        }
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string addr1 {
            get {
                return this.addr1Field;
            }
            set {
                this.addr1Field = value;
            }
        }
        
        /// <remarks/>
        public string addr2 {
            get {
                return this.addr2Field;
            }
            set {
                this.addr2Field = value;
            }
        }
        
        /// <remarks/>
        public string state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
        
        /// <remarks/>
        public string zip {
            get {
                return this.zipField;
            }
            set {
                this.zipField = value;
            }
        }
        
        /// <remarks/>
        public string country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }
        
        /// <remarks/>
        public string lat {
            get {
                return this.latField;
            }
            set {
                this.latField = value;
            }
        }
        
        /// <remarks/>
        public string lon {
            get {
                return this.lonField;
            }
            set {
                this.lonField = value;
            }
        }
        
        /// <remarks/>
        public string grid {
            get {
                return this.gridField;
            }
            set {
                this.gridField = value;
            }
        }
        
        /// <remarks/>
        public string county {
            get {
                return this.countyField;
            }
            set {
                this.countyField = value;
            }
        }
        
        /// <remarks/>
        public string ccode {
            get {
                return this.ccodeField;
            }
            set {
                this.ccodeField = value;
            }
        }
        
        /// <remarks/>
        public string fips {
            get {
                return this.fipsField;
            }
            set {
                this.fipsField = value;
            }
        }
        
        /// <remarks/>
        public string land {
            get {
                return this.landField;
            }
            set {
                this.landField = value;
            }
        }
        
        /// <remarks/>
        public string efdate {
            get {
                return this.efdateField;
            }
            set {
                this.efdateField = value;
            }
        }
        
        /// <remarks/>
        public string expdate {
            get {
                return this.expdateField;
            }
            set {
                this.expdateField = value;
            }
        }
        
        /// <remarks/>
        public string @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }
        
        /// <remarks/>
        public string codes {
            get {
                return this.codesField;
            }
            set {
                this.codesField = value;
            }
        }
        
        /// <remarks/>
        public string qslmgr {
            get {
                return this.qslmgrField;
            }
            set {
                this.qslmgrField = value;
            }
        }
        
        /// <remarks/>
        public string email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        public string u_views {
            get {
                return this.u_viewsField;
            }
            set {
                this.u_viewsField = value;
            }
        }
        
        /// <remarks/>
        public string bio {
            get {
                return this.bioField;
            }
            set {
                this.bioField = value;
            }
        }
        
        /// <remarks/>
        public string biodate {
            get {
                return this.biodateField;
            }
            set {
                this.biodateField = value;
            }
        }
        
        /// <remarks/>
        public string moddate {
            get {
                return this.moddateField;
            }
            set {
                this.moddateField = value;
            }
        }
        
        /// <remarks/>
        public string MSA {
            get {
                return this.mSAField;
            }
            set {
                this.mSAField = value;
            }
        }
        
        /// <remarks/>
        public string AreaCode {
            get {
                return this.areaCodeField;
            }
            set {
                this.areaCodeField = value;
            }
        }
        
        /// <remarks/>
        public string TimeZone {
            get {
                return this.timeZoneField;
            }
            set {
                this.timeZoneField = value;
            }
        }
        
        /// <remarks/>
        public string GMTOffset {
            get {
                return this.gMTOffsetField;
            }
            set {
                this.gMTOffsetField = value;
            }
        }
        
        /// <remarks/>
        public string DST {
            get {
                return this.dSTField;
            }
            set {
                this.dSTField = value;
            }
        }
        
        /// <remarks/>
        public string eqsl {
            get {
                return this.eqslField;
            }
            set {
                this.eqslField = value;
            }
        }
        
        /// <remarks/>
        public string mqsl {
            get {
                return this.mqslField;
            }
            set {
                this.mqslField = value;
            }
        }
        
        /// <remarks/>
        public string cqzone {
            get {
                return this.cqzoneField;
            }
            set {
                this.cqzoneField = value;
            }
        }
        
        /// <remarks/>
        public string ituzone {
            get {
                return this.ituzoneField;
            }
            set {
                this.ituzoneField = value;
            }
        }
        
        /// <remarks/>
        public string lotw {
            get {
                return this.lotwField;
            }
            set {
                this.lotwField = value;
            }
        }
        
        /// <remarks/>
        public string geoloc {
            get {
                return this.geolocField;
            }
            set {
                this.geolocField = value;
            }
        }
        
        /// <remarks/>
        public string name_fmt {
            get {
                return this.name_fmtField;
            }
            set {
                this.name_fmtField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://xmldata.qrz.com")]
    public partial class QRZDatabaseSession {
        
        private string keyField;
        
        private string countField;
        
        private string subExpField;
        
        private string gMTimeField;
        
        private string remarkField;

        private string errorField;
        
        private string messageField;
        
        /// <remarks/>
        public string Key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        public string Count {
            get {
                return this.countField;
            }
            set {
                this.countField = value;
            }
        }
        
        /// <remarks/>
        public string SubExp {
            get {
                return this.subExpField;
            }
            set {
                this.subExpField = value;
            }
        }
        
        /// <remarks/>
        public string GMTime {
            get {
                return this.gMTimeField;
            }
            set {
                this.gMTimeField = value;
            }
        }
        
        /// <remarks/>
        public string Remark {
            get {
                return this.remarkField;
            }
            set {
                this.remarkField = value;
            }
        }
        
        /// <remarks/>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public string Error {
            get {
                return this.errorField;
            }
            set {
                this.errorField = value;
            }
        }
        
        /// <remarks/>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
        
        public bool ShouldSerializeMessage() {
            return Message != null;
        }
        
        public bool ShouldSerializeError() {
            return Error != null;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://xmldata.qrz.com")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://xmldata.qrz.com", IsNullable=false)]
    public partial class NewDataSet {
        
        private QRZDatabase[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("QRZDatabase")]
        public QRZDatabase[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
}