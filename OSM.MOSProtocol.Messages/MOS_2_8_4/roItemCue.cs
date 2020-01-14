namespace OSM.MOS.Protocol.MOS_2_8_4
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class roItemCue {
        
        /// <remarks/>
        public string mosID;
        
        /// <remarks/>
        public string roID;
        
        /// <remarks/>
        public string storyID;
        
        /// <remarks/>
        public string itemID;
        
        /// <remarks/>
        public string roEventType;
        
        /// <remarks/>
        public System.DateTime roEventTime;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mosExternalMetadata")]
        public mosExternalMetadata[] mosExternalMetadata;
    }
}