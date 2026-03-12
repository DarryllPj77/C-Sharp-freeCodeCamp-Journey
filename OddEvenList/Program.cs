using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace OddEvenList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Loop from 0-20
             if number is even, add to even list
             if number is odd, add to odd list
             Print even list
             Print odd list
             */

            int num;
            do
            {
                string choice = "y";
                Console.Write("Do you want to continue? (yes/no): ");
                choice = Console.ReadLine();

                if(choice.ToLower() == "y")
                {
                    Console.Write("Enter number for task: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    switch (num)
                    {
                        case 1:
                            FirstTask();
                            break;
                        case 2:
                            SecondTask();
                            break;
                        case 3:
                            ThirdTask();
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }       
                }
                else if(choice.ToLower() != "y")
                {
                    Console.WriteLine("Program Ends!");
                    break;
                }
                else 
                {
                    Console.WriteLine("Program Ends!");
                }
            } while (true);

            ////int num = 0;
            //Console.Write("Enter number for task: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num == 1)
            //{
            //    FirstTask();
            //}
            //else
            //{
            //    SecondTask();
            //}

            ////Test();

        }

        static void FirstTask()
        {
            List<int> evenList = new List<int>();
            List<int> oddList = new List<int>();

            List<int> ListNumbers = new List<int>();
            //task 1
            Console.Write("Enter a number of list you want to put: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.Write("Enter the number you want to list: ");
                ListNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            //Display the List
            foreach (var list in ListNumbers)
            {
                //Console.Write(list + " ");
                if (list % 2 == 0) //if the number is even so it will be listed at even list
                {
                    evenList.Add(list);
                    Console.WriteLine("List for even: {0}", list);
                }
                else //(list % 3 == 0) // if number is odd so it will be listed at odd list
                {
                    oddList.Add(list);
                    Console.WriteLine("List for odd: {0}", list);
                }
            }
        }

        static void SecondTask()
        {
            int number;

            List<int> evenList = new List<int>();
            List<int> oddList = new List<int>();

            Console.WriteLine("========================================");
            Console.Write("Enter a number for a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    evenList.Add(i);
                    //Console.Write(i + " ");
                }
                else
                {
                    oddList.Add(i);
                    //Console.Write(i + " ");
                }
            }

            Console.Write("List for Even:");
            foreach (var list in evenList)
            {
                Console.Write(list + " ");
            }

            Console.WriteLine();
            Console.Write("List for Odd:");
            foreach (var list in oddList)
            {
                Console.Write(list + " ");
            }

            Console.WriteLine();
            
        }

        static void ThirdTask()
        {
            List<int> evenList = new List<int>();
            List<int> oddList = new List<int>();

            Console.WriteLine("========================================");
            Console.Write("Enter numbers in separated by space: ");
            string input = Console.ReadLine();

            string[] numbers = input.Split();

            foreach (var numStr in numbers)
            {
                int num = Convert.ToInt32(numStr);
                if (num % 2 == 0)
                {
                    evenList.Add(num);
                }
                else
                {
                    oddList.Add(num);
                }
            }

            Console.Write("List for Even: ");
            foreach (var num in evenList)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
            Console.Write("List for Odd: ");
            foreach (var num in oddList)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }
    }
}
