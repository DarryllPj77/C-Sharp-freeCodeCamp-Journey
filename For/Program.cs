using System;

namespace For
{
    class Program
    {
        public static void Main(string[] args)
        {
            int rows = 3;

            for(int i = 1; i <= rows; i++)
            {
                //print spaces
                for(int j = 1; j <= rows - i; j++)
                {
                    Console.Write("x");
                }
                //print stars
                for(int k = 1; k <= (2 * i - 1); k++) 
                {
                    Console.Write("*");
                }
                //next line
                Console.WriteLine();
            }
            
        }
    }
}