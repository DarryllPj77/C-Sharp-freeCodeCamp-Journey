using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task - Named Parameter");

            string nameInput = "Darryll";
            int ageInput = 21;
            string addressInput = "Manila";

            // Using Named Arguments to change the order
            // Syntax: parameterName: value
            PrintDetailsInfo(age: ageInput, name: nameInput, address: addressInput);
        }

        static void PrintDetailsInfo(string name, int age, string address)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Address: {address}");
        }
    }
    
}
