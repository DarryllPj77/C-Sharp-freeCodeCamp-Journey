
using System;

namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {

            //int attempts = 0;
            // Testing null or empty string
            for(int attempt = 1; attempt <= 3; attempt++)
            {
                string name;
                Console.Write("Enter your name: ");
                name = Console.ReadLine();

                Console.WriteLine("You Input named: {0}", name);

                // Testing if it is Empty string
                if(name == "Darryll")
                {
                    Console.WriteLine("Access Granted!");
                    break; // stop loop if correct
                }
                else if (name == " ")
                {
                    Console.WriteLine("It's Empty");
                    Console.WriteLine("Wrong! Attempt " + attempt + " of 3");
                }
                else if (name == "")
                {
                    Console.WriteLine("It's Empty with just Entering");
                    Console.WriteLine("Wrong! Attempt " + attempt + " of 3");
                }
                else
                {
                    Console.WriteLine("Not Empty");
                    Console.WriteLine("Wrong! Attempt " + attempt + " of 3");
                }

                if (attempt == 3)
                {
                    Console.WriteLine("No More attempts");
                }
            }
            Console.ReadKey();
        }
    }
}