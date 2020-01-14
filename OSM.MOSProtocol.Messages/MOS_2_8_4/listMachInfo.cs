namespace OSM.MOS.Protocol.MOS_2_8_4
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class listMachInfo {
        
        /// <remarks/>
        public string manufacturer;
        
        /// <remarks/>
        public string model;
        
        /// <remarks/>
        public string hwRev;
        
        /// <remarks/>
        public string swRev;
        
        /// <remarks/>
        public string DOM;
        
        /// <remarks/>
        public string SN;
        
        /// <remarks/>
        public string ID;
        
        /// <remarks/>
        public System.DateTime time;
        
        /// <remarks/>
        public System.DateTime opTime;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool opTimeSpecified;
        
        /// <remarks/>
        public string mosRev;
        
        /// <remarks/>
        public bool mosProfile0;
        
        /// <remarks/>
        public bool mosProfile1;
        
        /// <remarks/>
        public bool mosProfile2;
        
        /// <remarks/>
        public bool mosProfile3;
        
        /// <remarks/>
        public bool mosProfile4;
        
        /// <remarks/>
        public bool mosProfile5;
        
        /// <remarks/>
        public bool mosProfile6;
        
        /// <remarks/>
        public bool mosProfile7;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("defaultActiveX")]
        public defaultActiveX[] defaultActiveX;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mosExternalMetadata")]
        public mosExternalMetadata[] mosExternalMetadata;
    }
}