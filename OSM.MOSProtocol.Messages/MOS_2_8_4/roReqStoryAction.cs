namespace OSM.MOS.Protocol.MOS_2_8_4
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class roReqStoryAction {
        
        /// <remarks/>
        public roStorySend roStorySend;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public roReqStoryActionOperation operation;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string leaseLock;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string username;
    }
}