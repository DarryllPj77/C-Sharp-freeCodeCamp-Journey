using System;
using System.Threading.Channels;

namespace Reverse
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Enter a string then reverse it
            string reversed = ""; 

            Console.Write("Enter a message: ");
            string message = Console.ReadLine(); //Example message = Darryll => 7 string length
            for (int i = message.Length - 1; i >= 0; i--) // message.Length - 0 => 7th index
            {
                reversed += message[i];
            }
            Console.WriteLine("Reverse Output: {0} => {1}",message,reversed);
        }
    }
}