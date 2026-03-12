using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task - Optional Parameters");
            int result = Add(5);
            Console.WriteLine(result);

            Console.WriteLine("Print Name");
            PrintName("Celeine");

            Console.ReadLine();
        }
        // Function testing for default parameter
        static int Add(int a, [Optional] int b)
        {
            Console.WriteLine($"b = {b}"); // testing the value of the Optional Parameter
            return a + b;
        }

        static string PrintName(string name = "Daryll") // we set the default name for "Daryll"
        {
            Console.WriteLine($"Name: {name}");
            return name;
        }
    }
}
