using System;
using System.Collections.Generic;

namespace OutParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            //bool success = test(out num);
            test(out num);
            Console.WriteLine(num);
            //Console.WriteLine(success);
            //int.TryParse("123", out int result)

            List<string> shoppingList = new List<string>
            {
                "Coffee", "Milk"
            };

            Console.WriteLine(shoppingList.IndexOf("Coffee"));
            Console.WriteLine(FindInList("Milk", shoppingList, out int index));
            Console.Write(index);

            /*int index = -1; // 0 ->

            for (int i = 0; i < shoppingList.Count; i++)
            {
                if (shoppingList[i].ToLower().Equals("milk"))
                {
                    index = i;
                }
            }
            Console.WriteLine(index);
            bool found = index > -1;
            Console.WriteLine(found ? "Found" : "Not Found");*/

            Console.ReadLine();



        }
        
        static bool FindInList(string s, List<string> list, out int index)
        {
            index = -1; // 0 ->

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToLower().Equals(s.ToLower()))
                {
                    index = i;
                }
            }

            return index > -1;
        }

        static bool TryParse(string s, out int result)
        {
            result = 0;
            return true;
        }
        static void test(out int num)
        {
            //Console.WriteLine(num);
            num = 5;

            //return true;
        }

    }  
}
