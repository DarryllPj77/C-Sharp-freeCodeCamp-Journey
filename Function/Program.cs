using System;

namespace Function
{
    /// <summary>
    /// Test class demonstrates the difference between static and non-static methods.
    /// </summary>
    class Test
    {
        /// <summary>
        /// Static method that can be called directly from the class without creating an instance.
        /// </summary>
        public static void Test1()
        {
            Console.WriteLine("Test1");
        }

        /// <summary>
        /// Non-static (instance) method that requires an object instance to be called.
        /// </summary>
        public void Test2()
        {
            Console.WriteLine("Test2");
        }
    }

    /// <summary>
    /// Main program class that demonstrates method invocation patterns.
    /// </summary>
    class Program
    { 
        /// <summary>
        /// Non-static method that can only be called through an instance of the Program class.
        /// </summary>
        void something()
        {
            Console.WriteLine("Something code!");
        }

        /// <summary>
        /// Entry point of the application.
        /// Demonstrates calling static and non-static methods from different classes.
        /// </summary>
        static void Main(string[] args)
        {
            // Create an instance of Program to call non-static method
            Program program = new Program(); 
            program.something();

            // Call static method Test1 directly from Test class
            Test.Test1();

            // Create an instance of Test to call non-static method Test2
            Test test = new Test();
            test.Test2();
        }

        /// <summary>
        /// Static method for basic arithmetic operations.
        /// Prompts user for two numbers and displays their sum.
        /// </summary>
        static void Celeine_Code()
        {
            Console.WriteLine("Arithmetic");
            Console.Write("Enter a number for num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number for num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 + num2;

            Console.WriteLine($"Result: {result}");
        }
    }
}