﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace deuBarkod.EczaneIlacWS {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EczaneIlacWS.EczaneIlacSoap")]
    public interface EczaneIlacSoap {
        
        // CODEGEN: Generating message contract since message ilacListesiRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ilacListesi", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        deuBarkod.EczaneIlacWS.ilacListesiResponse ilacListesi(deuBarkod.EczaneIlacWS.ilacListesiRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class EczaneAuthHeader : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string usernameField;
        
        private string passwordField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Username {
            get {
                return this.usernameField;
            }
            set {
                this.usernameField = value;
                this.RaisePropertyChanged("Username");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
                this.RaisePropertyChanged("Password");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ilacListesi", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ilacListesiRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public deuBarkod.EczaneIlacWS.EczaneAuthHeader EczaneAuthHeader;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string sorguParametresi;
        
        public ilacListesiRequest() {
        }
        
        public ilacListesiRequest(deuBarkod.EczaneIlacWS.EczaneAuthHeader EczaneAuthHeader, string sorguParametresi) {
            this.EczaneAuthHeader = EczaneAuthHeader;
            this.sorguParametresi = sorguParametresi;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ilacListesiResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ilacListesiResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.Data.DataTable ilacListesiResult;
        
        public ilacListesiResponse() {
        }
        
        public ilacListesiResponse(System.Data.DataTable ilacListesiResult) {
            this.ilacListesiResult = ilacListesiResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface EczaneIlacSoapChannel : deuBarkod.EczaneIlacWS.EczaneIlacSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EczaneIlacSoapClient : System.ServiceModel.ClientBase<deuBarkod.EczaneIlacWS.EczaneIlacSoap>, deuBarkod.EczaneIlacWS.EczaneIlacSoap {
        
        public EczaneIlacSoapClient() {
        }
        
        public EczaneIlacSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EczaneIlacSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EczaneIlacSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EczaneIlacSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        deuBarkod.EczaneIlacWS.ilacListesiResponse deuBarkod.EczaneIlacWS.EczaneIlacSoap.ilacListesi(deuBarkod.EczaneIlacWS.ilacListesiRequest request) {
            return base.Channel.ilacListesi(request);
        }
        
        public System.Data.DataTable ilacListesi(deuBarkod.EczaneIlacWS.EczaneAuthHeader EczaneAuthHeader, string sorguParametresi) {
            deuBarkod.EczaneIlacWS.ilacListesiRequest inValue = new deuBarkod.EczaneIlacWS.ilacListesiRequest();
            inValue.EczaneAuthHeader = EczaneAuthHeader;
            inValue.sorguParametresi = sorguParametresi;
            deuBarkod.EczaneIlacWS.ilacListesiResponse retVal = ((deuBarkod.EczaneIlacWS.EczaneIlacSoap)(this)).ilacListesi(inValue);
            return retVal.ilacListesiResult;
        }
    }
}