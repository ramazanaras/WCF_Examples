﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Win_WebServices.MusteriService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MusteriResult", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class MusteriResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MusteriIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SirketAdiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MusteriAdiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefonField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string MusteriID {
            get {
                return this.MusteriIDField;
            }
            set {
                if ((object.ReferenceEquals(this.MusteriIDField, value) != true)) {
                    this.MusteriIDField = value;
                    this.RaisePropertyChanged("MusteriID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string SirketAdi {
            get {
                return this.SirketAdiField;
            }
            set {
                if ((object.ReferenceEquals(this.SirketAdiField, value) != true)) {
                    this.SirketAdiField = value;
                    this.RaisePropertyChanged("SirketAdi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string MusteriAdi {
            get {
                return this.MusteriAdiField;
            }
            set {
                if ((object.ReferenceEquals(this.MusteriAdiField, value) != true)) {
                    this.MusteriAdiField = value;
                    this.RaisePropertyChanged("MusteriAdi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Telefon {
            get {
                return this.TelefonField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefonField, value) != true)) {
                    this.TelefonField = value;
                    this.RaisePropertyChanged("Telefon");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MusteriService.MusteriServiceSoap")]
    public interface MusteriServiceSoap {
        
        // CODEGEN: Generating message contract since element name TumunuListeleResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TumunuListele", ReplyAction="*")]
        Win_WebServices.MusteriService.TumunuListeleResponse TumunuListele(Win_WebServices.MusteriService.TumunuListeleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TumunuListele", ReplyAction="*")]
        System.Threading.Tasks.Task<Win_WebServices.MusteriService.TumunuListeleResponse> TumunuListeleAsync(Win_WebServices.MusteriService.TumunuListeleRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TumunuListeleRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TumunuListele", Namespace="http://tempuri.org/", Order=0)]
        public Win_WebServices.MusteriService.TumunuListeleRequestBody Body;
        
        public TumunuListeleRequest() {
        }
        
        public TumunuListeleRequest(Win_WebServices.MusteriService.TumunuListeleRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class TumunuListeleRequestBody {
        
        public TumunuListeleRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TumunuListeleResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TumunuListeleResponse", Namespace="http://tempuri.org/", Order=0)]
        public Win_WebServices.MusteriService.TumunuListeleResponseBody Body;
        
        public TumunuListeleResponse() {
        }
        
        public TumunuListeleResponse(Win_WebServices.MusteriService.TumunuListeleResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class TumunuListeleResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Win_WebServices.MusteriService.MusteriResult[] TumunuListeleResult;
        
        public TumunuListeleResponseBody() {
        }
        
        public TumunuListeleResponseBody(Win_WebServices.MusteriService.MusteriResult[] TumunuListeleResult) {
            this.TumunuListeleResult = TumunuListeleResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MusteriServiceSoapChannel : Win_WebServices.MusteriService.MusteriServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MusteriServiceSoapClient : System.ServiceModel.ClientBase<Win_WebServices.MusteriService.MusteriServiceSoap>, Win_WebServices.MusteriService.MusteriServiceSoap {
        
        public MusteriServiceSoapClient() {
        }
        
        public MusteriServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MusteriServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MusteriServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MusteriServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Win_WebServices.MusteriService.TumunuListeleResponse Win_WebServices.MusteriService.MusteriServiceSoap.TumunuListele(Win_WebServices.MusteriService.TumunuListeleRequest request) {
            return base.Channel.TumunuListele(request);
        }
        
        public Win_WebServices.MusteriService.MusteriResult[] TumunuListele() {
            Win_WebServices.MusteriService.TumunuListeleRequest inValue = new Win_WebServices.MusteriService.TumunuListeleRequest();
            inValue.Body = new Win_WebServices.MusteriService.TumunuListeleRequestBody();
            Win_WebServices.MusteriService.TumunuListeleResponse retVal = ((Win_WebServices.MusteriService.MusteriServiceSoap)(this)).TumunuListele(inValue);
            return retVal.Body.TumunuListeleResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Win_WebServices.MusteriService.TumunuListeleResponse> Win_WebServices.MusteriService.MusteriServiceSoap.TumunuListeleAsync(Win_WebServices.MusteriService.TumunuListeleRequest request) {
            return base.Channel.TumunuListeleAsync(request);
        }
        
        public System.Threading.Tasks.Task<Win_WebServices.MusteriService.TumunuListeleResponse> TumunuListeleAsync() {
            Win_WebServices.MusteriService.TumunuListeleRequest inValue = new Win_WebServices.MusteriService.TumunuListeleRequest();
            inValue.Body = new Win_WebServices.MusteriService.TumunuListeleRequestBody();
            return ((Win_WebServices.MusteriService.MusteriServiceSoap)(this)).TumunuListeleAsync(inValue);
        }
    }
}
