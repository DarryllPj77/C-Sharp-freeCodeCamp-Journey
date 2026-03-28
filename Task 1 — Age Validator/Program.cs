using System;

namespace Task_1___Age_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1 — Age Validator");

            // Syntax (Declaration of TryParse) - Safe Conversion
            // Task create a simple 
            /* DISPLAY "Enter age"

               INPUT ageString

               IF TryParse ageString to integer age THEN
                     DISPLAY "Valid age"
               ELSE
                     DISPLAY "Invalid input"
               END IF*/
            
            Console.Write("Enter Age: ");
            string age = Console.ReadLine();

            Console.WriteLine($"You Entered: {age}"); // test confirmation

            bool isvalid = false;

            isvalid = int.TryParse(age, out int number);
            do
            {
                if (isvalid)
                {
                    Console.WriteLine("You Entered Valid Age!");
                }
                else
                {
                    Console.WriteLine("Invalid Age Input! Try again");
                    Console.Write("Enter Age: ");
                    age = Console.ReadLine();
                    isvalid = int.TryParse(age, out number);
                }

            } while (!isvalid);

            int ageNum = number;
            
            int newage = AgeAfter10Years(ageNum);
            Console.WriteLine($"Your {newage} years old after 10 years from now!");
            
        }
        static int AgeAfter10Years(int currentAge)
        {
            int num = 10; // plus 10 for your current age
            int yourAgeAfter10Years;
            yourAgeAfter10Years = num + currentAge;

            return yourAgeAfter10Years;
        }
    }
}
