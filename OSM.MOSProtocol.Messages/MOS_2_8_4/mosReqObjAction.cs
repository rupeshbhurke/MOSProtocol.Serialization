namespace OSM.MOS.Protocol.MOS_2_8_4
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class mosReqObjAction {
        
        /// <remarks/>
        public string objSlug;
        
        /// <remarks/>
        public System.Xml.XmlElement mosAbstract;
        
        /// <remarks/>
        public string objGroup;
        
        /// <remarks/>
        public objType objType;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool objTypeSpecified;
        
        /// <remarks/>
        public int objTB;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool objTBSpecified;
        
        /// <remarks/>
        public int objDur;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool objDurSpecified;
        
        /// <remarks/>
        public System.DateTime time;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool timeSpecified;
        
        /// <remarks/>
        public string createdBy;
        
        /// <remarks/>
        public string changedBy;
        
        /// <remarks/>
        public System.DateTime changed;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool changedSpecified;
        
        /// <remarks/>
        public description description;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mosExternalMetadata")]
        public mosExternalMetadata[] mosExternalMetadata;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public mosReqObjActionOperation operation;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string objID;
    }
}