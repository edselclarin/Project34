//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project34CLI.Project34WebServiceDev {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
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
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Project34WebServiceDev.Project34WebServiceSoap")]
    public interface Project34WebServiceSoap {
        
        // CODEGEN: Generating message contract since element name AboutResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/About", ReplyAction="*")]
        Project34CLI.Project34WebServiceDev.AboutResponse About(Project34CLI.Project34WebServiceDev.AboutRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/About", ReplyAction="*")]
        System.Threading.Tasks.Task<Project34CLI.Project34WebServiceDev.AboutResponse> AboutAsync(Project34CLI.Project34WebServiceDev.AboutRequest request);
        
        // CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Greeting", ReplyAction="*")]
        Project34CLI.Project34WebServiceDev.GreetingResponse Greeting(Project34CLI.Project34WebServiceDev.GreetingRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Greeting", ReplyAction="*")]
        System.Threading.Tasks.Task<Project34CLI.Project34WebServiceDev.GreetingResponse> GreetingAsync(Project34CLI.Project34WebServiceDev.GreetingRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        int Add(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int a, int b);
        
        // CODEGEN: Generating message contract since element name user from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GreetUser", ReplyAction="*")]
        Project34CLI.Project34WebServiceDev.GreetUserResponse GreetUser(Project34CLI.Project34WebServiceDev.GreetUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GreetUser", ReplyAction="*")]
        System.Threading.Tasks.Task<Project34CLI.Project34WebServiceDev.GreetUserResponse> GreetUserAsync(Project34CLI.Project34WebServiceDev.GreetUserRequest request);
        
        // CODEGEN: Generating message contract since element name GetUsersResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetUsers", ReplyAction="*")]
        Project34CLI.Project34WebServiceDev.GetUsersResponse GetUsers(Project34CLI.Project34WebServiceDev.GetUsersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetUsers", ReplyAction="*")]
        System.Threading.Tasks.Task<Project34CLI.Project34WebServiceDev.GetUsersResponse> GetUsersAsync(Project34CLI.Project34WebServiceDev.GetUsersRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AboutRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="About", Namespace="http://tempuri.org/", Order=0)]
        public Project34CLI.Project34WebServiceDev.AboutRequestBody Body;
        
        public AboutRequest() {
        }
        
        public AboutRequest(Project34CLI.Project34WebServiceDev.AboutRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AboutRequestBody {
        
        public AboutRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AboutResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AboutResponse", Namespace="http://tempuri.org/", Order=0)]
        public Project34CLI.Project34WebServiceDev.AboutResponseBody Body;
        
        public AboutResponse() {
        }
        
        public AboutResponse(Project34CLI.Project34WebServiceDev.AboutResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AboutResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string AboutResult;
        
        public AboutResponseBody() {
        }
        
        public AboutResponseBody(string AboutResult) {
            this.AboutResult = AboutResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GreetingRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Greeting", Namespace="http://tempuri.org/", Order=0)]
        public Project34CLI.Project34WebServiceDev.GreetingRequestBody Body;
        
        public GreetingRequest() {
        }
        
        public GreetingRequest(Project34CLI.Project34WebServiceDev.GreetingRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GreetingRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        public GreetingRequestBody() {
        }
        
        public GreetingRequestBody(string name) {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GreetingResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GreetingResponse", Namespace="http://tempuri.org/", Order=0)]
        public Project34CLI.Project34WebServiceDev.GreetingResponseBody Body;
        
        public GreetingResponse() {
        }
        
        public GreetingResponse(Project34CLI.Project34WebServiceDev.GreetingResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GreetingResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GreetingResult;
        
        public GreetingResponseBody() {
        }
        
        public GreetingResponseBody(string GreetingResult) {
            this.GreetingResult = GreetingResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GreetUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GreetUser", Namespace="http://tempuri.org/", Order=0)]
        public Project34CLI.Project34WebServiceDev.GreetUserRequestBody Body;
        
        public GreetUserRequest() {
        }
        
        public GreetUserRequest(Project34CLI.Project34WebServiceDev.GreetUserRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GreetUserRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Project34CLI.Project34WebServiceDev.User user;
        
        public GreetUserRequestBody() {
        }
        
        public GreetUserRequestBody(Project34CLI.Project34WebServiceDev.User user) {
            this.user = user;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GreetUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GreetUserResponse", Namespace="http://tempuri.org/", Order=0)]
        public Project34CLI.Project34WebServiceDev.GreetUserResponseBody Body;
        
        public GreetUserResponse() {
        }
        
        public GreetUserResponse(Project34CLI.Project34WebServiceDev.GreetUserResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GreetUserResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GreetUserResult;
        
        public GreetUserResponseBody() {
        }
        
        public GreetUserResponseBody(string GreetUserResult) {
            this.GreetUserResult = GreetUserResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetUsersRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetUsers", Namespace="http://tempuri.org/", Order=0)]
        public Project34CLI.Project34WebServiceDev.GetUsersRequestBody Body;
        
        public GetUsersRequest() {
        }
        
        public GetUsersRequest(Project34CLI.Project34WebServiceDev.GetUsersRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetUsersRequestBody {
        
        public GetUsersRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetUsersResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetUsersResponse", Namespace="http://tempuri.org/", Order=0)]
        public Project34CLI.Project34WebServiceDev.GetUsersResponseBody Body;
        
        public GetUsersResponse() {
        }
        
        public GetUsersResponse(Project34CLI.Project34WebServiceDev.GetUsersResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetUsersResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Project34CLI.Project34WebServiceDev.User[] GetUsersResult;
        
        public GetUsersResponseBody() {
        }
        
        public GetUsersResponseBody(Project34CLI.Project34WebServiceDev.User[] GetUsersResult) {
            this.GetUsersResult = GetUsersResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Project34WebServiceSoapChannel : Project34CLI.Project34WebServiceDev.Project34WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Project34WebServiceSoapClient : System.ServiceModel.ClientBase<Project34CLI.Project34WebServiceDev.Project34WebServiceSoap>, Project34CLI.Project34WebServiceDev.Project34WebServiceSoap {
        
        public Project34WebServiceSoapClient() {
        }
        
        public Project34WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Project34WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Project34WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Project34WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Project34CLI.Project34WebServiceDev.AboutResponse Project34CLI.Project34WebServiceDev.Project34WebServiceSoap.About(Project34CLI.Project34WebServiceDev.AboutRequest request) {
            return base.Channel.About(request);
        }
        
        public string About() {
            Project34CLI.Project34WebServiceDev.AboutRequest inValue = new Project34CLI.Project34WebServiceDev.AboutRequest();
            inValue.Body = new Project34CLI.Project34WebServiceDev.AboutRequestBody();
            Project34CLI.Project34WebServiceDev.AboutResponse retVal = ((Project34CLI.Project34WebServiceDev.Project34WebServiceSoap)(this)).About(inValue);
            return retVal.Body.AboutResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Project34CLI.Project34WebServiceDev.AboutResponse> Project34CLI.Project34WebServiceDev.Project34WebServiceSoap.AboutAsync(Project34CLI.Project34WebServiceDev.AboutRequest request) {
            return base.Channel.AboutAsync(request);
        }
        
        public System.Threading.Tasks.Task<Project34CLI.Project34WebServiceDev.AboutResponse> AboutAsync() {
            Project34CLI.Project34WebServiceDev.AboutRequest inValue = new Project34CLI.Project34WebServiceDev.AboutRequest();
            inValue.Body = new Project34CLI.Project34WebServiceDev.AboutRequestBody();
            return ((Project34CLI.Project34WebServiceDev.Project34WebServiceSoap)(this)).AboutAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Project34CLI.Project34WebServiceDev.GreetingResponse Project34CLI.Project34WebServiceDev.Project34WebServiceSoap.Greeting(Project34CLI.Project34WebServiceDev.GreetingRequest request) {
            return base.Channel.Greeting(request);
        }
        
        public string Greeting(string name) {
            Project34CLI.Project34WebServiceDev.GreetingRequest inValue = new Project34CLI.Project34WebServiceDev.GreetingRequest();
            inValue.Body = new Project34CLI.Project34WebServiceDev.GreetingRequestBody();
            inValue.Body.name = name;
            Project34CLI.Project34WebServiceDev.GreetingResponse retVal = ((Project34CLI.Project34WebServiceDev.Project34WebServiceSoap)(this)).Greeting(inValue);
            return retVal.Body.GreetingResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Project34CLI.Project34WebServiceDev.GreetingResponse> Project34CLI.Project34WebServiceDev.Project34WebServiceSoap.GreetingAsync(Project34CLI.Project34WebServiceDev.GreetingRequest request) {
            return base.Channel.GreetingAsync(request);
        }
        
        public System.Threading.Tasks.Task<Project34CLI.Project34WebServiceDev.GreetingResponse> GreetingAsync(string name) {
            Project34CLI.Project34WebServiceDev.GreetingRequest inValue = new Project34CLI.Project34WebServiceDev.GreetingRequest();
            inValue.Body = new Project34CLI.Project34WebServiceDev.GreetingRequestBody();
            inValue.Body.name = name;
            return ((Project34CLI.Project34WebServiceDev.Project34WebServiceSoap)(this)).GreetingAsync(inValue);
        }
        
        public int Add(int a, int b) {
            return base.Channel.Add(a, b);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int a, int b) {
            return base.Channel.AddAsync(a, b);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Project34CLI.Project34WebServiceDev.GreetUserResponse Project34CLI.Project34WebServiceDev.Project34WebServiceSoap.GreetUser(Project34CLI.Project34WebServiceDev.GreetUserRequest request) {
            return base.Channel.GreetUser(request);
        }
        
        public string GreetUser(Project34CLI.Project34WebServiceDev.User user) {
            Project34CLI.Project34WebServiceDev.GreetUserRequest inValue = new Project34CLI.Project34WebServiceDev.GreetUserRequest();
            inValue.Body = new Project34CLI.Project34WebServiceDev.GreetUserRequestBody();
            inValue.Body.user = user;
            Project34CLI.Project34WebServiceDev.GreetUserResponse retVal = ((Project34CLI.Project34WebServiceDev.Project34WebServiceSoap)(this)).GreetUser(inValue);
            return retVal.Body.GreetUserResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Project34CLI.Project34WebServiceDev.GreetUserResponse> Project34CLI.Project34WebServiceDev.Project34WebServiceSoap.GreetUserAsync(Project34CLI.Project34WebServiceDev.GreetUserRequest request) {
            return base.Channel.GreetUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<Project34CLI.Project34WebServiceDev.GreetUserResponse> GreetUserAsync(Project34CLI.Project34WebServiceDev.User user) {
            Project34CLI.Project34WebServiceDev.GreetUserRequest inValue = new Project34CLI.Project34WebServiceDev.GreetUserRequest();
            inValue.Body = new Project34CLI.Project34WebServiceDev.GreetUserRequestBody();
            inValue.Body.user = user;
            return ((Project34CLI.Project34WebServiceDev.Project34WebServiceSoap)(this)).GreetUserAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Project34CLI.Project34WebServiceDev.GetUsersResponse Project34CLI.Project34WebServiceDev.Project34WebServiceSoap.GetUsers(Project34CLI.Project34WebServiceDev.GetUsersRequest request) {
            return base.Channel.GetUsers(request);
        }
        
        public Project34CLI.Project34WebServiceDev.User[] GetUsers() {
            Project34CLI.Project34WebServiceDev.GetUsersRequest inValue = new Project34CLI.Project34WebServiceDev.GetUsersRequest();
            inValue.Body = new Project34CLI.Project34WebServiceDev.GetUsersRequestBody();
            Project34CLI.Project34WebServiceDev.GetUsersResponse retVal = ((Project34CLI.Project34WebServiceDev.Project34WebServiceSoap)(this)).GetUsers(inValue);
            return retVal.Body.GetUsersResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Project34CLI.Project34WebServiceDev.GetUsersResponse> Project34CLI.Project34WebServiceDev.Project34WebServiceSoap.GetUsersAsync(Project34CLI.Project34WebServiceDev.GetUsersRequest request) {
            return base.Channel.GetUsersAsync(request);
        }
        
        public System.Threading.Tasks.Task<Project34CLI.Project34WebServiceDev.GetUsersResponse> GetUsersAsync() {
            Project34CLI.Project34WebServiceDev.GetUsersRequest inValue = new Project34CLI.Project34WebServiceDev.GetUsersRequest();
            inValue.Body = new Project34CLI.Project34WebServiceDev.GetUsersRequestBody();
            return ((Project34CLI.Project34WebServiceDev.Project34WebServiceSoap)(this)).GetUsersAsync(inValue);
        }
    }
}
