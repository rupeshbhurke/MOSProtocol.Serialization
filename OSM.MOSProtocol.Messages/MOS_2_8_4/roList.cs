namespace OSM.MOS.Protocol.MOS_2_8_4
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class roList {
        
        /// <remarks/>
        public string roID;
        
        /// <remarks/>
        public string roSlug;
        
        /// <remarks/>
        public string roChannel;
        
        /// <remarks/>
        public System.DateTime roEdStart;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool roEdStartSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time")]
        public System.DateTime roEdDur;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool roEdDurSpecified;
        
        /// <remarks/>
        public string roTrigger;
        
        /// <remarks/>
        public string macroIn;
        
        /// <remarks/>
        public string macroOut;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mosExternalMetadata")]
        public mosExternalMetadata[] mosExternalMetadata;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("story")]
        public story[] story;
    }
}