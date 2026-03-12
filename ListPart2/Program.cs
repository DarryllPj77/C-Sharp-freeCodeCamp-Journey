using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List Part 2");
            List<int> listNumber = new List<int>();

            Console.Write("Enter a Number of how many numbers you want to input: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.Write("Enter number you want to list: ");
                listNumber.Add(Convert.ToInt32(Console.ReadLine()));
                //Console.WriteLine("Test");

            }

            Console.WriteLine("\nDisplay List");
            // To display the stored list inside the listNumber
            for (int i = 0; i < listNumber.Count; i++)
            {
                //Console.WriteLine(listNumber[i]);
                Console.WriteLine(listNumber[i]);
            }

            Console.WriteLine("\nReversed List");
            listNumber.Reverse();
            Console.Write("Reverse: ");
            foreach (var item in listNumber)
            {
                //listNumber.Reverse(item);
               Console.Write(""+item);
            }

            Console.WriteLine();
            Console.Write("Enter what number to remove from the index: ");
            int numberToRemove = Convert.ToInt32(Console.ReadLine());
            if (listNumber.Contains(numberToRemove))
            {
                listNumber.Remove(numberToRemove);
                Console.WriteLine("New List");
                foreach (var newItem in listNumber)
                {
                    Console.Write("" + newItem);
                }
            }
            else if(!listNumber.Contains(numberToRemove))
            {
                Console.WriteLine("The number {0} is not in the List", numberToRemove);
            }
            

            Console.ReadKey();
        }
    }
}
