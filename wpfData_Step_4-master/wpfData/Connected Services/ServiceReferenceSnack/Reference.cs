﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wpfData.ServiceReferenceSnack {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="CityList", Namespace="http://schemas.datacontract.org/2004/07/Model", ItemName="City")]
    [System.SerializableAttribute()]
    public class CityList : System.Collections.Generic.List<wpfData.ServiceReferenceSnack.City> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="City", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    public partial class City : wpfData.ServiceReferenceSnack.BaseEntity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CityName {
            get {
                return this.CityNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CityNameField, value) != true)) {
                    this.CityNameField = value;
                    this.RaisePropertyChanged("CityName");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseEntity", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(wpfData.ServiceReferenceSnack.User))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(wpfData.ServiceReferenceSnack.Snacks))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(wpfData.ServiceReferenceSnack.City))]
    public partial class BaseEntity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    public partial class User : wpfData.ServiceReferenceSnack.BaseEntity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private wpfData.ServiceReferenceSnack.City CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsAdminField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private wpfData.ServiceReferenceSnack.SnacksList MySnacksField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public wpfData.ServiceReferenceSnack.City City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsAdmin {
            get {
                return this.IsAdminField;
            }
            set {
                if ((this.IsAdminField.Equals(value) != true)) {
                    this.IsAdminField = value;
                    this.RaisePropertyChanged("IsAdmin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public wpfData.ServiceReferenceSnack.SnacksList MySnacks {
            get {
                return this.MySnacksField;
            }
            set {
                if ((object.ReferenceEquals(this.MySnacksField, value) != true)) {
                    this.MySnacksField = value;
                    this.RaisePropertyChanged("MySnacks");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Snacks", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    public partial class Snacks : wpfData.ServiceReferenceSnack.BaseEntity {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="SnacksList", Namespace="http://schemas.datacontract.org/2004/07/Model", ItemName="Snacks")]
    [System.SerializableAttribute()]
    public class SnacksList : System.Collections.Generic.List<wpfData.ServiceReferenceSnack.Snacks> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="UserList", Namespace="http://schemas.datacontract.org/2004/07/Model", ItemName="User")]
    [System.SerializableAttribute()]
    public class UserList : System.Collections.Generic.List<wpfData.ServiceReferenceSnack.User> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceSnack.IServiceSnack")]
    public interface IServiceSnack {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnack/GetAllCites", ReplyAction="http://tempuri.org/IServiceSnack/GetAllCitesResponse")]
        wpfData.ServiceReferenceSnack.CityList GetAllCites();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnack/GetAllCites", ReplyAction="http://tempuri.org/IServiceSnack/GetAllCitesResponse")]
        System.Threading.Tasks.Task<wpfData.ServiceReferenceSnack.CityList> GetAllCitesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnack/GetAllUsers", ReplyAction="http://tempuri.org/IServiceSnack/GetAllUsersResponse")]
        wpfData.ServiceReferenceSnack.UserList GetAllUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnack/GetAllUsers", ReplyAction="http://tempuri.org/IServiceSnack/GetAllUsersResponse")]
        System.Threading.Tasks.Task<wpfData.ServiceReferenceSnack.UserList> GetAllUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnack/GetAllSnack", ReplyAction="http://tempuri.org/IServiceSnack/GetAllSnackResponse")]
        wpfData.ServiceReferenceSnack.SnacksList GetAllSnack();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnack/GetAllSnack", ReplyAction="http://tempuri.org/IServiceSnack/GetAllSnackResponse")]
        System.Threading.Tasks.Task<wpfData.ServiceReferenceSnack.SnacksList> GetAllSnackAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnack/GetSnackByUser", ReplyAction="http://tempuri.org/IServiceSnack/GetSnackByUserResponse")]
        wpfData.ServiceReferenceSnack.SnacksList GetSnackByUser(wpfData.ServiceReferenceSnack.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnack/GetSnackByUser", ReplyAction="http://tempuri.org/IServiceSnack/GetSnackByUserResponse")]
        System.Threading.Tasks.Task<wpfData.ServiceReferenceSnack.SnacksList> GetSnackByUserAsync(wpfData.ServiceReferenceSnack.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnack/GetUserBysnack", ReplyAction="http://tempuri.org/IServiceSnack/GetUserBysnackResponse")]
        wpfData.ServiceReferenceSnack.UserList GetUserBysnack(wpfData.ServiceReferenceSnack.Snacks snack);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnack/GetUserBysnack", ReplyAction="http://tempuri.org/IServiceSnack/GetUserBysnackResponse")]
        System.Threading.Tasks.Task<wpfData.ServiceReferenceSnack.UserList> GetUserBysnackAsync(wpfData.ServiceReferenceSnack.Snacks snack);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnack/Login", ReplyAction="http://tempuri.org/IServiceSnack/LoginResponse")]
        wpfData.ServiceReferenceSnack.User Login(wpfData.ServiceReferenceSnack.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnack/Login", ReplyAction="http://tempuri.org/IServiceSnack/LoginResponse")]
        System.Threading.Tasks.Task<wpfData.ServiceReferenceSnack.User> LoginAsync(wpfData.ServiceReferenceSnack.User user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceSnackChannel : wpfData.ServiceReferenceSnack.IServiceSnack, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceSnackClient : System.ServiceModel.ClientBase<wpfData.ServiceReferenceSnack.IServiceSnack>, wpfData.ServiceReferenceSnack.IServiceSnack {
        
        public ServiceSnackClient() {
        }
        
        public ServiceSnackClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceSnackClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSnackClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSnackClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public wpfData.ServiceReferenceSnack.CityList GetAllCites() {
            return base.Channel.GetAllCites();
        }
        
        public System.Threading.Tasks.Task<wpfData.ServiceReferenceSnack.CityList> GetAllCitesAsync() {
            return base.Channel.GetAllCitesAsync();
        }
        
        public wpfData.ServiceReferenceSnack.UserList GetAllUsers() {
            return base.Channel.GetAllUsers();
        }
        
        public System.Threading.Tasks.Task<wpfData.ServiceReferenceSnack.UserList> GetAllUsersAsync() {
            return base.Channel.GetAllUsersAsync();
        }
        
        public wpfData.ServiceReferenceSnack.SnacksList GetAllSnack() {
            return base.Channel.GetAllSnack();
        }
        
        public System.Threading.Tasks.Task<wpfData.ServiceReferenceSnack.SnacksList> GetAllSnackAsync() {
            return base.Channel.GetAllSnackAsync();
        }
        
        public wpfData.ServiceReferenceSnack.SnacksList GetSnackByUser(wpfData.ServiceReferenceSnack.User user) {
            return base.Channel.GetSnackByUser(user);
        }
        
        public System.Threading.Tasks.Task<wpfData.ServiceReferenceSnack.SnacksList> GetSnackByUserAsync(wpfData.ServiceReferenceSnack.User user) {
            return base.Channel.GetSnackByUserAsync(user);
        }
        
        public wpfData.ServiceReferenceSnack.UserList GetUserBysnack(wpfData.ServiceReferenceSnack.Snacks snack) {
            return base.Channel.GetUserBysnack(snack);
        }
        
        public System.Threading.Tasks.Task<wpfData.ServiceReferenceSnack.UserList> GetUserBysnackAsync(wpfData.ServiceReferenceSnack.Snacks snack) {
            return base.Channel.GetUserBysnackAsync(snack);
        }
        
        public wpfData.ServiceReferenceSnack.User Login(wpfData.ServiceReferenceSnack.User user) {
            return base.Channel.Login(user);
        }
        
        public System.Threading.Tasks.Task<wpfData.ServiceReferenceSnack.User> LoginAsync(wpfData.ServiceReferenceSnack.User user) {
            return base.Channel.LoginAsync(user);
        }
    }
}
