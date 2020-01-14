namespace OSM.MOS.Protocol.MOS_2_8_4
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class p {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("b", typeof(b))]
        [System.Xml.Serialization.XmlElementAttribute("em", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("i", typeof(i))]
        [System.Xml.Serialization.XmlElementAttribute("pi", typeof(pi))]
        [System.Xml.Serialization.XmlElementAttribute("pkg", typeof(pkg))]
        [System.Xml.Serialization.XmlElementAttribute("tab", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("u", typeof(u))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text;
    }
}