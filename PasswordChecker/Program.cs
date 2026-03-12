using System;

namespace Password
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Password Checker exercise
            Console.Write("Please Enter your password: ");
            string PASSWORD = Console.ReadLine();

            Console.Write("Please Enter your password Confirmation: ");
            string confirmPASSWORD = Console.ReadLine();

            if(PASSWORD != confirmPASSWORD)
            {
                Console.WriteLine("Password do not match");
            }
            else if (PASSWORD == confirmPASSWORD)
            {
                Console.WriteLine("Password match");
            }
        }
    }
}