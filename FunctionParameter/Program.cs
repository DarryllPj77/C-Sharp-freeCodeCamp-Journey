using System;
using System.Reflection;


namespace FunctionParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task Today - Function parameter

            //Console.Write("Enter a number for num1: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter a number for num1: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            (int num1, int num2, int a, int b) = ReadIntFromConsole(30, 40);
            int addNumbers = num1 + num2;
            int AddNum = a + b;

            Console.WriteLine("addNumbers Output: {0}", addNumbers);
            Console.WriteLine("AddNum Output: {0}" , AddNum);

            //int sum = Add(10, 10);
            //Console.WriteLine(sum);

            int firstNumber = ReadInt("Enter First Number:");
            int secondNumber = ReadInt("Enter First Number:");
            int result = Add(firstNumber, secondNumber);

            Console.WriteLine(result);

            //Console.Write("Enter a number for num1: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter a number for num1: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int sum = (Add(num1, num2));
            //Console.WriteLine("The sum for Function Add(): " + sum);
        }


        /*static int ReadIntFromConsoleNum1(string number)
        {
            Console.Write("Enter a number for num1: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int ReadIntFromConsoleNum2(string number)
        {
            Console.Write("Enter a number for num2: ");
            return Convert.ToInt32(Console.ReadLine());
        }*/

        static (int, int, int, int) ReadIntFromConsole(int a, int b)
        {
            Console.Write("Enter a number for num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a number for num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("For Function: ReadIntFromConsole(int a, int b)");
            Console.WriteLine($"Display parameter: {a} and {b}");

            return (num1, num2, a, b);
        }

        static int Add(int a, int b)
        {
            //int c = 0;
            //c = a + b;
            //return c;

            return a + b;
        }

        static int ReadInt(string message)
        {
            Console.Write($"{message} ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
