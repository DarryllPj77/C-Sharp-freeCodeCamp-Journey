using System;
using System.Runtime.InteropServices;

namespace Dictionary
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nDictionary");
            Dictionary<int, string> names = new Dictionary<int, string>
            {
                // Key-Value Pair
                {1, "Darryll" },
                {2, "Celeine" },
                {3, "Mochie" }
            };

            //for (int i = 0; i < names.Count; i++)
            //{
            //    KeyValuePair<int, string> pair = names.ElementAt(i);
            //    Console.WriteLine($"{pair.Key} - {pair.Value}");
            //}

            foreach(KeyValuePair<int, string> pair in names)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }

            //Dictionary - With teacher and subject scenario
            Dictionary<string, string> teachers = new Dictionary<string, string>
            {
                {"Math", "Darryll" },
                {"ESP", "Celeine" },
                {"Science", "Mochi" },
                {"English", "Joe" }
            };

            //foreach(var subject in teacher)
            //{
            //    Console.WriteLine($"{subject.Key} - {subject.Value}");
            //}

            Console.WriteLine("====================\n");
            Console.WriteLine(teachers["Math"]);
            if(teachers.TryGetValue("Math", out string teacher))
            {
                Console.WriteLine(teacher);
                teachers["Math"] = "Joe";
            }
            else
            {
                Console.WriteLine("Math teacher not found");
            }
            Console.WriteLine(teachers["Math"]);
            Console.WriteLine(teachers["English"]);
            Console.WriteLine(teachers["Mochi"]);
            Console.ReadKey();
        }
    }
}