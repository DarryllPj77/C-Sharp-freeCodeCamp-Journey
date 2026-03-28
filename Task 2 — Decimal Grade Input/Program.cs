using System;

namespace Task_2___Decimal_Grade_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 2 — Decimal Grade Input
            /*DISPLAY "Enter grade"

            INPUT gradeString

            IF TryParse gradeString to double grade THEN
                  DISPLAY grade
            ELSE
                  DISPLAY "Invalid grade"
            END IF*/

            Console.Write("Enter Grade: ");
            string grade = Console.ReadLine();

            bool valid = double.TryParse(grade, out double number);

            do
            {
                // for validation true or false
                if (valid)
                {
                    Console.WriteLine($"You Entered Your Grade: {number}");
                }
                else
                {
                    Console.WriteLine("Invalid Grade Input! Try Again");
                    Console.Write("Enter Grade: ");
                    grade = Console.ReadLine();
                    valid = double.TryParse(grade, out number);
                }

            } while (!valid);

            //char computedGrade = gradeComputation(number);
            //Console.WriteLine(computedGrade);

            functionCaller(number);


            //functionCaller();
        }

        static void functionCaller(double gradeValue)
        {
            char computedGrade = gradeComputation(gradeValue);
            Console.WriteLine("Your grade is: {0}", computedGrade);

            string gradeOutcome = GradeOutcome(gradeValue);
            Console.WriteLine(gradeOutcome);
        }

        static string GradeOutcome(double grade)
        {
            if (grade >= 70)
            {
                return $"PASS ({grade}%)";
            }
            else
            {
                return $"FAIL ({grade}%)";
            }
        }

        static char gradeComputation(double grade)
        {
            if(grade >= 90)
            {
                return 'A';
            }
            else if(grade >= 80)
            {
                return 'B';
            }
            else if(grade >= 70)
            {
                return 'C';
            }else if(grade >= 60) 
            {
                return 'D';
            }
            else
            {
                return 'F';
            }

        }  

    }
}
