﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment2_Section1Client.EmployeeClient {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/Assignment2_Section1")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DeptField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmpFNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmpLNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmpNoField;
        
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
        public string Dept {
            get {
                return this.DeptField;
            }
            set {
                if ((object.ReferenceEquals(this.DeptField, value) != true)) {
                    this.DeptField = value;
                    this.RaisePropertyChanged("Dept");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmpFName {
            get {
                return this.EmpFNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EmpFNameField, value) != true)) {
                    this.EmpFNameField = value;
                    this.RaisePropertyChanged("EmpFName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmpLName {
            get {
                return this.EmpLNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EmpLNameField, value) != true)) {
                    this.EmpLNameField = value;
                    this.RaisePropertyChanged("EmpLName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EmpNo {
            get {
                return this.EmpNoField;
            }
            set {
                if ((this.EmpNoField.Equals(value) != true)) {
                    this.EmpNoField = value;
                    this.RaisePropertyChanged("EmpNo");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeClient.IEmployeeService")]
    public interface IEmployeeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/RetrieveEmployees", ReplyAction="http://tempuri.org/IEmployeeService/RetrieveEmployeesResponse")]
        Assignment2_Section1Client.EmployeeClient.Employee[] RetrieveEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/RetrieveEmployees", ReplyAction="http://tempuri.org/IEmployeeService/RetrieveEmployeesResponse")]
        System.Threading.Tasks.Task<Assignment2_Section1Client.EmployeeClient.Employee[]> RetrieveEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/RetrieveEmployeeByID", ReplyAction="http://tempuri.org/IEmployeeService/RetrieveEmployeeByIDResponse")]
        Assignment2_Section1Client.EmployeeClient.Employee RetrieveEmployeeByID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/RetrieveEmployeeByID", ReplyAction="http://tempuri.org/IEmployeeService/RetrieveEmployeeByIDResponse")]
        System.Threading.Tasks.Task<Assignment2_Section1Client.EmployeeClient.Employee> RetrieveEmployeeByIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/AddEmployees", ReplyAction="http://tempuri.org/IEmployeeService/AddEmployeesResponse")]
        int AddEmployees(Assignment2_Section1Client.EmployeeClient.Employee emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/AddEmployees", ReplyAction="http://tempuri.org/IEmployeeService/AddEmployeesResponse")]
        System.Threading.Tasks.Task<int> AddEmployeesAsync(Assignment2_Section1Client.EmployeeClient.Employee emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/UpdateEmployees", ReplyAction="http://tempuri.org/IEmployeeService/UpdateEmployeesResponse")]
        int UpdateEmployees(int id, Assignment2_Section1Client.EmployeeClient.Employee emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/UpdateEmployees", ReplyAction="http://tempuri.org/IEmployeeService/UpdateEmployeesResponse")]
        System.Threading.Tasks.Task<int> UpdateEmployeesAsync(int id, Assignment2_Section1Client.EmployeeClient.Employee emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/DeleteEmployees", ReplyAction="http://tempuri.org/IEmployeeService/DeleteEmployeesResponse")]
        int DeleteEmployees(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/DeleteEmployees", ReplyAction="http://tempuri.org/IEmployeeService/DeleteEmployeesResponse")]
        System.Threading.Tasks.Task<int> DeleteEmployeesAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeServiceChannel : Assignment2_Section1Client.EmployeeClient.IEmployeeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeServiceClient : System.ServiceModel.ClientBase<Assignment2_Section1Client.EmployeeClient.IEmployeeService>, Assignment2_Section1Client.EmployeeClient.IEmployeeService {
        
        public EmployeeServiceClient() {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Assignment2_Section1Client.EmployeeClient.Employee[] RetrieveEmployees() {
            return base.Channel.RetrieveEmployees();
        }
        
        public System.Threading.Tasks.Task<Assignment2_Section1Client.EmployeeClient.Employee[]> RetrieveEmployeesAsync() {
            return base.Channel.RetrieveEmployeesAsync();
        }
        
        public Assignment2_Section1Client.EmployeeClient.Employee RetrieveEmployeeByID(int id) {
            return base.Channel.RetrieveEmployeeByID(id);
        }
        
        public System.Threading.Tasks.Task<Assignment2_Section1Client.EmployeeClient.Employee> RetrieveEmployeeByIDAsync(int id) {
            return base.Channel.RetrieveEmployeeByIDAsync(id);
        }
        
        public int AddEmployees(Assignment2_Section1Client.EmployeeClient.Employee emp) {
            return base.Channel.AddEmployees(emp);
        }
        
        public System.Threading.Tasks.Task<int> AddEmployeesAsync(Assignment2_Section1Client.EmployeeClient.Employee emp) {
            return base.Channel.AddEmployeesAsync(emp);
        }
        
        public int UpdateEmployees(int id, Assignment2_Section1Client.EmployeeClient.Employee emp) {
            return base.Channel.UpdateEmployees(id, emp);
        }
        
        public System.Threading.Tasks.Task<int> UpdateEmployeesAsync(int id, Assignment2_Section1Client.EmployeeClient.Employee emp) {
            return base.Channel.UpdateEmployeesAsync(id, emp);
        }
        
        public int DeleteEmployees(int id) {
            return base.Channel.DeleteEmployees(id);
        }
        
        public System.Threading.Tasks.Task<int> DeleteEmployeesAsync(int id) {
            return base.Channel.DeleteEmployeesAsync(id);
        }
    }
}
