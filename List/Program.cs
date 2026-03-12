using System;

namespace listAndDictionary
{
    class Program
    {
        public static void Main(string[] args)
        {

            //List

            int[] numbers = new int[3]
            {
                1, 2, 3
            };

            List<int> listNumbers = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter a number: ");
                //int num = Convert.ToInt32(Console.ReadLine());
                //listNumbers.Add(num);
                listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            //for (int i = 0; i < listNumbers.Count; i++)
            //{
            //    //Console.WriteLine(i);
            //    Console.WriteLine(listNumbers[i]);
            //}

            foreach(var item in listNumbers)
            {
                Console.WriteLine(item);
            }
            

            Console.ReadKey();
        }
    }
}