﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KuzeyRuzgariWeb.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Urun", Namespace="http://schemas.datacontract.org/2004/07/KuzeyRuzgari.Model.DTO")]
    [System.SerializableAttribute()]
    public partial class Urun : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<short> StokField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UrunAdiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UrunIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<short> Stok {
            get {
                return this.StokField;
            }
            set {
                if ((this.StokField.Equals(value) != true)) {
                    this.StokField = value;
                    this.RaisePropertyChanged("Stok");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UrunAdi {
            get {
                return this.UrunAdiField;
            }
            set {
                if ((object.ReferenceEquals(this.UrunAdiField, value) != true)) {
                    this.UrunAdiField = value;
                    this.RaisePropertyChanged("UrunAdi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UrunID {
            get {
                return this.UrunIDField;
            }
            set {
                if ((this.UrunIDField.Equals(value) != true)) {
                    this.UrunIDField = value;
                    this.RaisePropertyChanged("UrunID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Kategori", Namespace="http://schemas.datacontract.org/2004/07/KuzeyRuzgari.Model.DTO")]
    [System.SerializableAttribute()]
    public partial class Kategori : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KategoriAdiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int KategoriIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string KategoriAdi {
            get {
                return this.KategoriAdiField;
            }
            set {
                if ((object.ReferenceEquals(this.KategoriAdiField, value) != true)) {
                    this.KategoriAdiField = value;
                    this.RaisePropertyChanged("KategoriAdi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int KategoriID {
            get {
                return this.KategoriIDField;
            }
            set {
                if ((this.KategoriIDField.Equals(value) != true)) {
                    this.KategoriIDField = value;
                    this.RaisePropertyChanged("KategoriID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IProduct")]
    public interface IProduct {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/GetAllProduct", ReplyAction="http://tempuri.org/IProduct/GetAllProductResponse")]
        KuzeyRuzgariWeb.ServiceReference1.Urun[] GetAllProduct();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProduct/GetAllProduct", ReplyAction="http://tempuri.org/IProduct/GetAllProductResponse")]
        System.Threading.Tasks.Task<KuzeyRuzgariWeb.ServiceReference1.Urun[]> GetAllProductAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProductChannel : KuzeyRuzgariWeb.ServiceReference1.IProduct, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductClient : System.ServiceModel.ClientBase<KuzeyRuzgariWeb.ServiceReference1.IProduct>, KuzeyRuzgariWeb.ServiceReference1.IProduct {
        
        public ProductClient() {
        }
        
        public ProductClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public KuzeyRuzgariWeb.ServiceReference1.Urun[] GetAllProduct() {
            return base.Channel.GetAllProduct();
        }
        
        public System.Threading.Tasks.Task<KuzeyRuzgariWeb.ServiceReference1.Urun[]> GetAllProductAsync() {
            return base.Channel.GetAllProductAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ICategory")]
    public interface ICategory {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategory/GetAllCategories", ReplyAction="http://tempuri.org/ICategory/GetAllCategoriesResponse")]
        KuzeyRuzgariWeb.ServiceReference1.Kategori[] GetAllCategories();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategory/GetAllCategories", ReplyAction="http://tempuri.org/ICategory/GetAllCategoriesResponse")]
        System.Threading.Tasks.Task<KuzeyRuzgariWeb.ServiceReference1.Kategori[]> GetAllCategoriesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICategoryChannel : KuzeyRuzgariWeb.ServiceReference1.ICategory, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CategoryClient : System.ServiceModel.ClientBase<KuzeyRuzgariWeb.ServiceReference1.ICategory>, KuzeyRuzgariWeb.ServiceReference1.ICategory {
        
        public CategoryClient() {
        }
        
        public CategoryClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CategoryClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CategoryClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CategoryClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public KuzeyRuzgariWeb.ServiceReference1.Kategori[] GetAllCategories() {
            return base.Channel.GetAllCategories();
        }
        
        public System.Threading.Tasks.Task<KuzeyRuzgariWeb.ServiceReference1.Kategori[]> GetAllCategoriesAsync() {
            return base.Channel.GetAllCategoriesAsync();
        }
    }
}