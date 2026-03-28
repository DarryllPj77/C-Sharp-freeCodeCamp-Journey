using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Darryll";
            int age; 
            age = 21; 

            if(age > 18)
            {
                Console.WriteLine("18+");
            }

            PrintDetails(name, age);

            string message = readFromConsole("Enter anything: ");
            Console.WriteLine(message);

            Console.ReadLine();
        }

        static void PrintDetails(string name, int age)
        {
            Console.WriteLine($"{name} - {age}");
        }

        static string readFromConsole(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}
