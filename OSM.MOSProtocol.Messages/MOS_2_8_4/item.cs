namespace OSM.MOS.Protocol.MOS_2_8_4
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class item {
        
        /// <remarks/>
        public string itemID;
        
        /// <remarks/>
        public string itemSlug;
        
        /// <remarks/>
        public string objID;
        
        /// <remarks/>
        public string mosID;
        
        /// <remarks/>
        public string mosPlugInID;
        
        /// <remarks/>
        public System.Xml.XmlElement mosAbstract;
        
        /// <remarks/>
        public objPaths objPaths;
        
        /// <remarks/>
        public string itemChannel;
        
        /// <remarks/>
        public int itemEdStart;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemEdStartSpecified;
        
        /// <remarks/>
        public int itemEdDur;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemEdDurSpecified;
        
        /// <remarks/>
        public int itemUserTimingDur;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemUserTimingDurSpecified;
        
        /// <remarks/>
        public string itemTrigger;
        
        /// <remarks/>
        public string macroIn;
        
        /// <remarks/>
        public string macroOut;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mosExternalMetadata")]
        public mosExternalMetadata[] mosExternalMetadata;
    }
}