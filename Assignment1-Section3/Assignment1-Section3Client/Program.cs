using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment1_Section3Client
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Calcultor: ");
            Console.Write("Enter the first number:");
            int a =Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number:");
            int b = Convert.ToInt32(Console.ReadLine());
            CalculatorServiceProxy.CalculatorClient client = new CalculatorServiceProxy.CalculatorClient();
            Console.WriteLine("Addition Result: " + client.Addition(a, b));
            Console.WriteLine("Subtraction Result: " + client.Subtraction(a, b));
            Console.ReadLine();

        }
    }
}
