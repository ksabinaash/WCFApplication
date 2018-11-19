using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Assignment2_Section1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in both code and config file together.
    public class EmployeeService : IEmployeeService
    {
        public int AddEmployees(Employee emp)
        {
            int result = 0;
            string connetionString = @"Data Source=DOTNET;Initial Catalog=Assignment;Integrated Security=true";
            using (SqlConnection c = new SqlConnection(connetionString))
            {
                c.Open();
                using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO EMPLOYEE ([EmpNo],[EmpFname],[EmpLname],[Dept]) VALUES ("+emp.EmpNo+", '"+ emp.EmpFName + "', '" + emp.EmpLName + "', '" + emp.Dept + "')" , c))
                {
                    result = sqlCommand.ExecuteNonQuery();
                }
            }
            return result;
        }

        public int DeleteEmployees(int id)
        {
            int result = 0;
            string connetionString = @"Data Source=DOTNET;Initial Catalog=Assignment;Integrated Security=true";
            using (SqlConnection c = new SqlConnection(connetionString))
            {
                c.Open();
                using (SqlCommand sqlCommand = new SqlCommand("DELETE FROM EMPLOYEE WHERE EmpNo=" + id, c))
                {
                    result = sqlCommand.ExecuteNonQuery();
                }
            }
            return result;
        }

        public Employee RetrieveEmployeeByID(int id)
        {
            Employee employee = new Employee();
            string connetionString = @"Data Source=DOTNET;Initial Catalog=Assignment;Integrated Security=true";
            using (SqlConnection c = new SqlConnection(connetionString))
            {
                c.Open();
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM EMPLOYEE WHERE EmpNo=" + id, c))
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        employee.EmpNo = Convert.ToInt32(reader["EmpNo"].ToString());
                        employee.EmpFName = reader["EmpFName"].ToString();
                        employee.EmpLName = reader["EmpLName"].ToString();
                        employee.Dept = reader["Dept"].ToString();
                    }
                    reader.Close();
                }
            }
            return employee;
        }

        public List<Employee> RetrieveEmployees()
        {
            List<Employee> employees = new List<Employee>();
            string connetionString = @"Data Source=DOTNET;Initial Catalog=Assignment;Integrated Security=true";
            using (SqlConnection c = new SqlConnection(connetionString))
            {
                c.Open();
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM EMPLOYEE", c))
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        Employee employee = new Employee();
                        employee.EmpNo = Convert.ToInt32(reader["EmpNo"].ToString());
                        employee.EmpFName = reader["EmpFName"].ToString();
                        employee.EmpLName = reader["EmpLName"].ToString();
                        employee.Dept = reader["Dept"].ToString();
                        employees.Add(employee);
                    }
                    reader.Close();
                }
            }
            return employees;
        }

        public int UpdateEmployees(int id, Employee emp)
        {
            int result = 0;
            string connetionString = @"Data Source=DOTNET;Initial Catalog=Assignment;Integrated Security=true";
            using (SqlConnection c = new SqlConnection(connetionString))
            {
                c.Open();
                using (SqlCommand sqlCommand = new SqlCommand("UPDATE EMPLOYEE SET EmpFName='" + emp.EmpFName+"', EmpLname='" + emp.EmpLName + "', Dept='"+ emp.Dept+"' WHERE EmpNo=" + id, c))
                {
                    result = sqlCommand.ExecuteNonQuery();
                }
            }
            return result;
        }
    }
}
