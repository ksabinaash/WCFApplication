using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Assignment2_Section1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployeeService" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeService
    {
        [OperationContract]
        List<Employee> RetrieveEmployees();
        [OperationContract]
        Employee RetrieveEmployeeByID(int id);
        [OperationContract]
        int AddEmployees(Employee emp);
        [OperationContract]
        int UpdateEmployees(int id, Employee emp);
        [OperationContract]
        int DeleteEmployees(int id);
    }
}
