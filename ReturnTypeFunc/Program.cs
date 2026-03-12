using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace ReturnTypeFunc
{
    internal class Program
    {
        //static string name = "Darryll";
        static void Main(string[] args) // Main Function
        {
            Console.Title = $"Name: {ReturnName()} - Age: {ReturnAge()}";
            PrintIntroduction();
            int arraySize = 0;
            //int[] numbers = new int[arraySize];

            Console.Write("Enter the size of the array: ");
            arraySize = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[arraySize];

            for (int i = 0; i < numbers.Length; i++)
            {
                //Console.Write("Enter a number: ");
                //numbers[i] = Convert.ToInt32(Console.ReadLine());
                numbers[i] = ReadNumberFromConsole(i);
            }

            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }

            //New Array List
            int[] newNumbers = CreateRandomArray();
            Console.WriteLine("NewList with Index value");
            for (int i = 0; i < newNumbers.Length; i++)
            {
                Console.WriteLine($"New List[{i}]:{newNumbers[i]}"); //check index value 
            }

            //Sum of the Listed arrays
            Console.WriteLine("Add Array");
            int sum = AddArray(newNumbers); // test
            Console.WriteLine(sum);

            //Reverse the array list
            int[] Reversed = ArrayReversed(newNumbers);
            Console.Write("Reversed Array: ");
            foreach(var reversed in Reversed)
            {
                Console.Write(reversed);
            }

            Console.WriteLine();
            //Your Name
            char[] yourName = ArrayName();
            foreach(var name in yourName)
            {
                Console.Write(name);
            }

            Console.WriteLine();
            //Reversed String name
            char[] reversedName = ReversedName(yourName);
            Console.Write("Reversed Name:");
            foreach(var name in reversedName)
            {
                Console.Write(name);
            }


            Console.ReadLine();
        }

        //Reversed String name
        static char[] ReversedName(char[] reversedName)
        {
            Array.Reverse(reversedName);
            return reversedName;
        }

        static char[] ArrayName()
        {
            //Console.Write("Enter Your name in character format: ");
            //ring[] arrayName = new string[1]; // 1 string -> Darryll OLD
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine();
            //Will list the length of the name
            Console.Write("Name Length: ");
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(i); // test
            }
            Console.WriteLine();
            // Convert string to character array
            char[] nameChars = name.ToCharArray();

            //string[] arrayName = new string[name.Length];
            //Console.WriteLine();
            //for (int i = 0; i < arrayName.Length; i++)
            //{
            //    Console.Write("Enter Your name in character format: ");
            //    arrayName[i] = Console.ReadLine();
            //}

            //Testing output of name
            //foreach (var name in arrayName)
            //{
            //    Console.WriteLine(name);
            //}
            //arrayName[] = Console.ReadLine();

            return nameChars;
        }

        static int[] ArrayReversed(int[] reversedArray)
        {
            Array.Reverse(reversedArray);
            return reversedArray;
        }
        static int AddArray(int[] numbers)
        {
            int sum = 0;
            foreach(var num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        static int[] CreateRandomArray()
        {
            int arraySize;
            Console.Write("\nEnter a Array size for new Array List: ");
            arraySize = Convert.ToInt32(Console.ReadLine());

            //int arraySize = 0;
            int[] numbers = new int[arraySize]; //example 3 => 0,1,2

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter Array Value: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                
            }

            return numbers;
        }

        static int ReadNumberFromConsole(int index)
        {
            Console.Write("Enter a number for index:[{0}]:", index);
            return Convert.ToInt32(Console.ReadLine());
        }



        static string ReturnName()
        {
            return "Darryll";
        }

        static int ReturnAge()
        {
            return 21;
        }

        static void PrintIntroduction()
        {
            //string name = ReturnName();
            //int age = ReturnAge();
            //string intro = string.Format("My name is {0} and im {1} years old", name, age);
            //Console.WriteLine(intro);

            //Console.WriteLine("My name is {0} and im {1} years old", ReturnName(), ReturnAge()); // -alternative way
            Console.WriteLine($"My name is {ReturnName()} and Im {ReturnAge()} years old");
        }
    }
}
