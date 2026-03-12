using System;

namespace array
{
    class Program
    {
        public static void Main(string[] args)
        {
            //int sum = 0;
            ////To assign what number length needed
            //Console.Write("Enter number length: ");
            //int numLength = Convert.ToInt32(Console.ReadLine());

            //int[] numbers = new int[numLength]; // so numbers length = 4

            ////To assigned all number created to numbers[i]
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write("Enter number: ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //// To Print the all output
            //Console.WriteLine("OUTPUT: ");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"You Entered:{numbers[i]}");
            //    sum += numbers[i];
            //}
            //Console.WriteLine("Sum of all inputed arrays: {0}", sum);
            //Console.ReadKey();


            //// Array Cleaning
            //int[] numbers = new int[]
            //{
            //    1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            //};
            ////Array.Clear(arrayName, startIndex, length); syntax

            ////Array.Clear(numbers, 1, numbers.Length);
            //Array.Clear(numbers, 1, 5);

            ////for (int i = 5; i < numbers.Length; i++)
            ////{
            ////    numbers[i] = default;
            ////}

            //foreach (var item in numbers)
            //{
            //    Console.Write($" {item}");
            //}

            //array IndexOf
            int[] numbers = new int[]
            {
                99, 199, 22, 50, 30
            };

            Console.Write("Enter number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            ////Array.IndexOf(arrayName, valueToFind); Syntax
            int position = Array.IndexOf(numbers, search);
            //int position = Array.IndexOf(numbers, search, 1, 2);

            //if(position > -1)
            //{
            //    Console.WriteLine($"Number {search} has been found at {position}");
            //}
            //else
            //{
            //    Console.WriteLine($"number {search} has not been found");
            //}

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] == search)
            //    {
            //        position = i;
            //    }
            //}

            if (position > -1)
            {
                Console.WriteLine($"Number {search} has been found at {position}");
            }
            else
            {
                Console.WriteLine($"number {search} has not been found");
            }

            Console.ReadKey();
        }
    }
}