using System;
using System.Threading;

namespace NullOrEmpty
{
    class Program
    {
        public static void Main(string[] args) 
        {
            string name = " ";
            //int attempt = 0;
            //Attemps for Name


            for (int attempt = 1; attempt <= 3; attempt++)
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();

                Console.WriteLine("Your name is {0}", name);

                //Console.WriteLine("Not Empty String");
                if (!string.IsNullOrEmpty(name))
                {
                    // All this is True if user input any string even if it just a space
                    if(name == null)
                    {
                        Console.WriteLine("You justed entered! Attempt " + attempt + " of 3");
                    }
                    else if(name == " ")
                    {
                        Console.WriteLine("You didn't enter anything! Attempt " + attempt + " of 3");
                    }else if(name != "Darryll")
                    {
                        Console.WriteLine("Wrong Name! Attempt " + attempt + " of 3");
                    }else if(name == "")
                    {
                        Console.WriteLine("You justed entered! Attempt " + attempt + " of 3");
                    }
                }
                if (name.Equals("Darryll"))
                {
                    Console.Write("Initializing Host![");
                    for (int k = 0; k <= 50; k++)
                    {
                        Console.Write("#");
                        Thread.Sleep(50);
                    }
                    Console.Write("]");
                    Console.WriteLine("\nCorrect");
                    break;
                }
                else if (name == "") // Since User just entered it will be false for [if (!string.IsNullOrEmpty(name))]
                {
                    Console.WriteLine("You just entered! Attempt " + attempt + " of 3");
                }
                if (attempt == 3)
                {
                    Console.WriteLine("NO MORE ATTEMPTS");
                }
            }
                Console.ReadKey();
        }
    }
}