using System;

namespace Stars
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create a pyramid with Stars
            int rows = 0;
            Console.Write("Enter a number: ");
            rows = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= rows; i++)
            {
                //spaces
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}