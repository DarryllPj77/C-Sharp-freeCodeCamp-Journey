using System;
using System.Threading.Channels;


namespace Swicth
{
    class Program
    {
        static void Main(String[] args)
        {
            int day;
            do
            {
                Console.Write("Enter a Day of the week: ");
                day = Convert.ToInt32(Console.ReadLine());

                switch (day)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Satuday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        Console.WriteLine("Invalid, enter a value between 1 to 7!");
                        break;
                }
                Console.WriteLine("Please Try Again");
            } while (day < 1 || day >= 7);
            Console.WriteLine("Thank you!");


            Console.ReadKey();

            //Console.ReadLine();

           
        }
    }
}