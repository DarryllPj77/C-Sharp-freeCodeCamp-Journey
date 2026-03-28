using System;

namespace Task_4___Date_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*DISPLAY "Enter reservation date"

            INPUT dateString

            IF TryParse dateString to Date THEN
                  DISPLAY "Date saved"
            ELSE
                  DISPLAY "Invalid date"
            END IF*/


            Console.Write("Enter Reservation Date: ");
            string dateInput = Console.ReadLine();

            bool valid = DateTime.TryParse(dateInput, out DateTime date);
            do
            {
                if (valid)
                {
                    Console.WriteLine($"{date:d} Saved!");
                }
                else
                {
                    Console.WriteLine("Invalid Date");
                    Console.Write("Enter Reservation Date: ");
                    dateInput = Console.ReadLine();
                    valid = DateTime.TryParse(dateInput, out date);
                }
            } while (!valid);

            
        }
    }
}
