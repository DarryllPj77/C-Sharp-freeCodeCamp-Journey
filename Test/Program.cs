
using System;

namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            //int num = 5;
            int num = update(5);
            Console.WriteLine(num);
            
            
            Console.ReadKey();
        }

        public static int update(int x)
        {
            x = x + 10;
            return x;
            //Console.WriteLine();
        }
    }
}