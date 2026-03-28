using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomTryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * Create a int and try convert any string to a int
            * Notice the error, write a try...catch handler around it
            * Catch the error and output the error message
            * Without changing the current code
            *
            * Why is this a bad situation and how can we know if its been converted?
            *
            * Create a custom try parse function
            * Find the real function and copy return type/params
            * Read the tooltip it gives you, to give you ideas on what to do
            */

            Console.WriteLine("Task - Custom TryParse");

            /*bool success = false;
            //codes here
            try
            {
                Console.Write("Enter a number: "); // string here, convert to int
                int num = Convert.ToInt32(Console.ReadLine());
                success = true;

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(success ? "Yey" : "Oh noo");
            Console.ReadLine();*/

            Console.Write("Enter a number: ");
            if (TryParse(Console.ReadLine(), out int result))
            {
                Console.WriteLine("Yey " + result);
            }
            else
            {
                Console.WriteLine("Oh no");
            }

                Console.ReadLine();
        }

        static bool TryParse(string input, out int result)
        {
            result = -1;
            try
            {
                result = Convert.ToInt32(input);
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }
    }
}
