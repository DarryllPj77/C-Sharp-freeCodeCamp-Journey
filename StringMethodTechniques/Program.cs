using System;
using System.Threading;

namespace stringtechniques
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("String Techniques");

            string name = "Darryll";
            int age = 21;
            // string interpolation
            Console.WriteLine($"Your name is {name}, your age is {age}");

            // string composition or concatenation 
            Console.WriteLine("Your name is " + name + ", your age is " + age);

            // string formatting 
            Console.WriteLine("Your name is {0}, your age is {1}", name, age);

            // string iteration looping example
            string messages = "C# is awesomeCCCCC";
            Console.WriteLine(messages[0]);
            Console.WriteLine(messages[1]);
            Console.WriteLine(messages[2]);
            Console.WriteLine(messages[3]);
            Console.WriteLine(messages[4]);
            Console.WriteLine(messages[5]);

            foreach ( char message in messages)
            {
                Console.Write(message);
                Thread.Sleep(50); //100ms = 1 sec
            }

            Console.WriteLine();
            //Console.WriteLine(messages.Contains("C"));

            bool contains = false;
            for(int i = 0; i < messages.Length; i++)
            {
                //if (messages[i].Equals('C'))
                //{
                //    contains = true;
                //}
                if (messages[i].Equals('C'))
                {
                    Console.WriteLine("Index num[{0}]:There is C", i);
                }
                else
                {
                    Console.WriteLine("Index num[{0}]", i);
                }
            }
            //Console.WriteLine(contains);

            Console.ReadKey();
        }
    }
}