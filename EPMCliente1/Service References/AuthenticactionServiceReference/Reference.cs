﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EPMCliente1.AuthenticactionServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AuthenticactionServiceReference.IAuthenticationService")]
    public interface IAuthenticationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthenticationService/ValidateUser", ReplyAction="http://tempuri.org/IAuthenticationService/ValidateUserResponse")]
        bool ValidateUser(string username, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuthenticationServiceChannel : EPMCliente1.AuthenticactionServiceReference.IAuthenticationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthenticationServiceClient : System.ServiceModel.ClientBase<EPMCliente1.AuthenticactionServiceReference.IAuthenticationService>, EPMCliente1.AuthenticactionServiceReference.IAuthenticationService {
        
        public AuthenticationServiceClient() {
        }
        
        public AuthenticationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthenticationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool ValidateUser(string username, string password) {
            return base.Channel.ValidateUser(username, password);
        }
    }
}