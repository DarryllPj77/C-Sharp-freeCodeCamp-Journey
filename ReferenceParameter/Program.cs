using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task: Reference Parameter");

            //int num = 10;
            //string name = "Darryll";

            //Assign(ref num, ref name);

            //Console.WriteLine(num);
            //Console.WriteLine(name);

            string name = "Darryll";
            Console.Write("Enter your name: ");
            string newName = Console.ReadLine();

            if(ChangeName(ref name, newName))
            {
                Console.WriteLine("My New name:" + name);
            }
            else
            {
                Console.WriteLine("New name cannot be empty or null!");
            }


        }

        /*static void ChangeName(ref string name, string newName)
        {
            name = newName;
        }*/
        static bool ChangeName(ref string name, string newName)
        {
            if (!string.IsNullOrEmpty(newName))
            {
                name = newName;
                return true;
            }

            return false;
        }

            static void Assign(ref int num, ref string name)
        {
            name = "Celeine";
            num = 100;
        }
    }
}
