﻿namespace OSM.MOS.Protocol.MOS_2_8_4
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class roItemReplace {
        
        /// <remarks/>
        public string roID;
        
        /// <remarks/>
        public string storyID;
        
        /// <remarks/>
        public string itemID;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("item")]
        public item[] item;
    }
}