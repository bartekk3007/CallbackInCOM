﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Klient2.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IZadanie1")]
    public interface IZadanie1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IZadanie1/DlugieObliczenia", ReplyAction="http://tempuri.org/IZadanie1/DlugieObliczeniaResponse")]
        string DlugieObliczenia();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IZadanie1/DlugieObliczenia", ReplyAction="http://tempuri.org/IZadanie1/DlugieObliczeniaResponse")]
        System.Threading.Tasks.Task<string> DlugieObliczeniaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IZadanie1/Szybciej", ReplyAction="http://tempuri.org/IZadanie1/SzybciejResponse")]
        string Szybciej(int x, int fx);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IZadanie1/Szybciej", ReplyAction="http://tempuri.org/IZadanie1/SzybciejResponse")]
        System.Threading.Tasks.Task<string> SzybciejAsync(int x, int fx);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IZadanie1Channel : Klient2.ServiceReference1.IZadanie1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Zadanie1Client : System.ServiceModel.ClientBase<Klient2.ServiceReference1.IZadanie1>, Klient2.ServiceReference1.IZadanie1 {
        
        public Zadanie1Client() {
        }
        
        public Zadanie1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Zadanie1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Zadanie1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Zadanie1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string DlugieObliczenia() {
            return base.Channel.DlugieObliczenia();
        }
        
        public System.Threading.Tasks.Task<string> DlugieObliczeniaAsync() {
            return base.Channel.DlugieObliczeniaAsync();
        }
        
        public string Szybciej(int x, int fx) {
            return base.Channel.Szybciej(x, fx);
        }
        
        public System.Threading.Tasks.Task<string> SzybciejAsync(int x, int fx) {
            return base.Channel.SzybciejAsync(x, fx);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IZadanie2", CallbackContract=typeof(Klient2.ServiceReference1.IZadanie2Callback))]
    public interface IZadanie2 {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IZadanie2/PodajZadania")]
        void PodajZadania();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IZadanie2/PodajZadania")]
        System.Threading.Tasks.Task PodajZadaniaAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IZadanie2Callback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IZadanie2/Zadanie")]
        void Zadanie([System.ServiceModel.MessageParameterAttribute(Name="zadanie")] string zadanie1, int pkt, bool zaliczone);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IZadanie2Channel : Klient2.ServiceReference1.IZadanie2, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Zadanie2Client : System.ServiceModel.DuplexClientBase<Klient2.ServiceReference1.IZadanie2>, Klient2.ServiceReference1.IZadanie2 {
        
        public Zadanie2Client(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public Zadanie2Client(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public Zadanie2Client(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public Zadanie2Client(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public Zadanie2Client(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void PodajZadania() {
            base.Channel.PodajZadania();
        }
        
        public System.Threading.Tasks.Task PodajZadaniaAsync() {
            return base.Channel.PodajZadaniaAsync();
        }
    }
}
