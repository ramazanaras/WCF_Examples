﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wcf_Giris.UrunlerServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UrunDTO", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    [System.SerializableAttribute()]
    public partial class UrunDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BirimdekiMiktarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<short> EnAzYenidenSatisMikatariField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> FiyatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> KategoriIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SonlandiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<short> StokField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> TedarikciIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UrunAdiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UrunIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UrunResimUrlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<short> YeniSatisField;
        
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
        public string BirimdekiMiktar {
            get {
                return this.BirimdekiMiktarField;
            }
            set {
                if ((object.ReferenceEquals(this.BirimdekiMiktarField, value) != true)) {
                    this.BirimdekiMiktarField = value;
                    this.RaisePropertyChanged("BirimdekiMiktar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<short> EnAzYenidenSatisMikatari {
            get {
                return this.EnAzYenidenSatisMikatariField;
            }
            set {
                if ((this.EnAzYenidenSatisMikatariField.Equals(value) != true)) {
                    this.EnAzYenidenSatisMikatariField = value;
                    this.RaisePropertyChanged("EnAzYenidenSatisMikatari");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> Fiyat {
            get {
                return this.FiyatField;
            }
            set {
                if ((this.FiyatField.Equals(value) != true)) {
                    this.FiyatField = value;
                    this.RaisePropertyChanged("Fiyat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> KategoriID {
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Sonlandi {
            get {
                return this.SonlandiField;
            }
            set {
                if ((this.SonlandiField.Equals(value) != true)) {
                    this.SonlandiField = value;
                    this.RaisePropertyChanged("Sonlandi");
                }
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
        public System.Nullable<int> TedarikciID {
            get {
                return this.TedarikciIDField;
            }
            set {
                if ((this.TedarikciIDField.Equals(value) != true)) {
                    this.TedarikciIDField = value;
                    this.RaisePropertyChanged("TedarikciID");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UrunResimUrl {
            get {
                return this.UrunResimUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.UrunResimUrlField, value) != true)) {
                    this.UrunResimUrlField = value;
                    this.RaisePropertyChanged("UrunResimUrl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<short> YeniSatis {
            get {
                return this.YeniSatisField;
            }
            set {
                if ((this.YeniSatisField.Equals(value) != true)) {
                    this.YeniSatisField = value;
                    this.RaisePropertyChanged("YeniSatis");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UrunlerServiceReference.IUrunlerService")]
    public interface IUrunlerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUrunlerService/DoWork", ReplyAction="http://tempuri.org/IUrunlerService/DoWorkResponse")]
        string DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUrunlerService/DoWork", ReplyAction="http://tempuri.org/IUrunlerService/DoWorkResponse")]
        System.Threading.Tasks.Task<string> DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUrunlerService/UrunListesi", ReplyAction="http://tempuri.org/IUrunlerService/UrunListesiResponse")]
        System.Collections.Generic.List<Wcf_Giris.UrunlerServiceReference.UrunDTO> UrunListesi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUrunlerService/UrunListesi", ReplyAction="http://tempuri.org/IUrunlerService/UrunListesiResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Wcf_Giris.UrunlerServiceReference.UrunDTO>> UrunListesiAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUrunlerServiceChannel : Wcf_Giris.UrunlerServiceReference.IUrunlerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UrunlerServiceClient : System.ServiceModel.ClientBase<Wcf_Giris.UrunlerServiceReference.IUrunlerService>, Wcf_Giris.UrunlerServiceReference.IUrunlerService {
        
        public UrunlerServiceClient() {
        }
        
        public UrunlerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UrunlerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UrunlerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UrunlerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string DoWork() {
            return base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task<string> DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public System.Collections.Generic.List<Wcf_Giris.UrunlerServiceReference.UrunDTO> UrunListesi() {
            return base.Channel.UrunListesi();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Wcf_Giris.UrunlerServiceReference.UrunDTO>> UrunListesiAsync() {
            return base.Channel.UrunListesiAsync();
        }
    }
}