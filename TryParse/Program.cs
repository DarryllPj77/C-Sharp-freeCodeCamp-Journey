using System;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task Practice for using TryParse");

            bool isInvalid; // Track if we need to keep looping

            do
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                // You can declare 'int number' right here in the 'out' parameter
                if (int.TryParse(input, out int number))
                {
                    Console.WriteLine($"Success! Your number is: {number}");
                    isInvalid = false; // Stop the loop
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please enter a valid integer.");
                    isInvalid = true; // Continue the loop
                }

            } while (isInvalid);
        }
    }
}
