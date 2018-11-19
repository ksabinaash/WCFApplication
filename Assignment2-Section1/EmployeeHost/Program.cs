using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHost
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(Assignment2_Section1.EmployeeService)))
            {
                host.Open();
                Console.WriteLine("The Employee Service is open");
                Console.ReadLine();
            }
        }
    }
}
