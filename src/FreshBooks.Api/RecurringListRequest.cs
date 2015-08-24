﻿namespace FreshBooks.Api.RecurringList {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class request {
        
        private byte client_idField;
        
        private System.DateTime date_fromField;
        
        private System.DateTime date_toField;
        
        private string updated_fromField;
        
        private string updated_toField;
        
        private byte autobillField;
        
        private byte pageField;
        
        private byte per_pageField;
        
        private string folderField;
        
        private string methodField = "recurring.list";
        
        /// <remarks/>
        public byte client_id {
            get {
                return this.client_idField;
            }
            set {
                this.client_idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime date_from {
            get {
                return this.date_fromField;
            }
            set {
                this.date_fromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime date_to {
            get {
                return this.date_toField;
            }
            set {
                this.date_toField = value;
            }
        }
        
        /// <remarks/>
        public string updated_from {
            get {
                return this.updated_fromField;
            }
            set {
                this.updated_fromField = value;
            }
        }
        
        /// <remarks/>
        public string updated_to {
            get {
                return this.updated_toField;
            }
            set {
                this.updated_toField = value;
            }
        }
        
        /// <remarks/>
        public byte autobill {
            get {
                return this.autobillField;
            }
            set {
                this.autobillField = value;
            }
        }
        
        /// <remarks/>
        public byte page {
            get {
                return this.pageField;
            }
            set {
                this.pageField = value;
            }
        }
        
        /// <remarks/>
        public byte per_page {
            get {
                return this.per_pageField;
            }
            set {
                this.per_pageField = value;
            }
        }
        
        /// <remarks/>
        public string folder {
            get {
                return this.folderField;
            }
            set {
                this.folderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string method {
            get {
                return this.methodField;
            }
            set {
                this.methodField = value;
            }
        }
    }
}

		