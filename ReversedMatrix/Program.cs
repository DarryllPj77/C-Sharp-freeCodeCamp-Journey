using System;
using System.Linq;

namespace ReversedMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reversed Test");
            //array
            int[] array = new int[5]
            {
                1,2,3,4,5
            };

            Console.Write("Original Array: ");
            foreach(var list in array)
            {
                Console.Write(list);
            }

            Console.WriteLine();
            int[] reversedArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++) //array.Length = 5
            {
                reversedArray[i] = array[array.Length - 1 - i];
            }
            Console.Write("Reversed Array: ");
            foreach (var list in reversedArray)
            {
                Console.Write(list);
            }

            //int[] reversedArray;

            /*foreach (var list in array)
            {
                Console.Write(list);
            }

            Array.Reverse(array);

            Console.WriteLine("\nReversed Array: ");
            foreach (var item in array)
            {
                Console.Write(item);
            }*/




            Console.ReadLine();
        }
    }
}
