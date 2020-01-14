namespace OSM.MOS.Protocol.MOS_2_8_4
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class roAck {
        
        /// <remarks/>
        public string roID;
        
        /// <remarks/>
        public string roStatus;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("storyID")]
        public string[] storyID;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("itemID")]
        public string[] itemID;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("objID")]
        public string[] objID;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("itemChannel")]
        public string[] itemChannel;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("status")]
        public string[] status;
    }
}