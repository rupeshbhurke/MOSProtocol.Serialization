namespace OSM.MOS.Protocol.MOS_2_8_4
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class mosObjList {
        
        /// <remarks/>
        public string queryID;
        
        /// <remarks/>
        public int listReturnStart;
        
        /// <remarks/>
        public int listReturnEnd;
        
        /// <remarks/>
        public int listReturnTotal;
        
        /// <remarks/>
        public string listReturnStatus;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("mosObj", IsNullable=false)]
        public mosObj[] list;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string username;
    }
}