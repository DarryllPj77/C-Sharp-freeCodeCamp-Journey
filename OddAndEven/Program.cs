using System;
using System.Threading.Channels;

namespace fizzbuzz
{
    class Program
    {
        public static void Main(string[] args)
        {
            //for(int i = 1; i <= 15; i++)
            //{
            //    //9 % 3 = 0

            //}

            int num1, num2;
            float mod;

            Console.WriteLine("Modulus");
            Console.Write("Enter number for num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number for num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            mod = num1 % num2;

            Console.WriteLine("Remainder Result: " + mod);

            Console.WriteLine("Num1 & Num2 Odd or Even Checker");
            // to check if the num1 is odd or even
            if(num1 % 2 == 0 )
            {
                Console.WriteLine("Num1 is even");
            }
            else
            {
                Console.WriteLine("Num1 is odd");
            }

            if (num2 % 2 == 0)
            {
                Console.WriteLine("Num1 is even");
            }
            else
            {
                Console.WriteLine("Num1 is odd");
            }

            Console.WriteLine("Divisibility test sequence for Input number");
            int number = 0;
            Console.Write("Enter a number");
            number = Convert.ToInt32(Console.ReadLine());
            // Entering a number to get if all the value is odd or even
            for(int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + ": is Divisible by two");
                }
                else if (i % 3 == 0){
                    Console.WriteLine(i + ": is Divisible by three");
                }
                else if (i % 5 == 0)
                    Console.WriteLine(i + ": is Divisible by five");
            }

            Console.ReadKey();

        }
    }
}