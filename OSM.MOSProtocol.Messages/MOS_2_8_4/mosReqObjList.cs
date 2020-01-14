namespace OSM.MOS.Protocol.MOS_2_8_4
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class mosReqObjList {
        
        /// <remarks/>
        public string queryID;
        
        /// <remarks/>
        public int listReturnStart;
        
        /// <remarks/>
        public int listReturnEnd;
        
        /// <remarks/>
        public string generalSearch;
        
        /// <remarks/>
        public string mosSchema;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("searchField", typeof(searchField), IsNullable=false)]
        public searchField[][] searchGroup;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string username;
    }
}