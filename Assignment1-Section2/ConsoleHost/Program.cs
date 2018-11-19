using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHost
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(Assignment1_Section2.JobService)))
            {
                host.Open();
                Console.WriteLine("The host is open");
                Console.ReadLine();
            }
        }
    }
}
