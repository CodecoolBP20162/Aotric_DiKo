﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GoodbyeWebClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IGoodbyeService")]
    public interface IGoodbyeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGoodbyeService/GetMessage", ReplyAction="http://tempuri.org/IGoodbyeService/GetMessageResponse")]
        string GetMessage(string msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGoodbyeService/GetMessage", ReplyAction="http://tempuri.org/IGoodbyeService/GetMessageResponse")]
        System.Threading.Tasks.Task<string> GetMessageAsync(string msg);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGoodbyeServiceChannel : GoodbyeWebClient.ServiceReference1.IGoodbyeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GoodbyeServiceClient : System.ServiceModel.ClientBase<GoodbyeWebClient.ServiceReference1.IGoodbyeService>, GoodbyeWebClient.ServiceReference1.IGoodbyeService {
        
        public GoodbyeServiceClient() {
        }
        
        public GoodbyeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GoodbyeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GoodbyeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GoodbyeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetMessage(string msg) {
            return base.Channel.GetMessage(msg);
        }
        
        public System.Threading.Tasks.Task<string> GetMessageAsync(string msg) {
            return base.Channel.GetMessageAsync(msg);
        }
    }
}
