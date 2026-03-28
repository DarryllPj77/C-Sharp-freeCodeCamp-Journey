using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try Catch Task");

            try
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please enter only number less than 2 billion");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please Enter proper Format");
            }
            catch (Exception)
            {
                Console.WriteLine("Something was Wrong");
            }
        }
    }
}
