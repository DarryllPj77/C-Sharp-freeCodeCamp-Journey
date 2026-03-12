using System;
using System.Diagnostics.Metrics;

namespace ArrayMultiplier
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Array multiplier

            Console.Write("Enter the array size: ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            int counter = 0;
            int[] result = new int[arrayLength];

            Console.Write("Enter the what number to be multiplied: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= result.Length; i++, counter++)
            {
                result[counter] = num * i;
                //counter++;
            }

            foreach(var list in result)
            {
                Console.Write($"{list} ");
            }

            Console.WriteLine();
        }
    }
}