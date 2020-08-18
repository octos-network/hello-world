using System;
using System.Collections.Generic;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = new List<string>();

            shoppingList.Add("Half Life 3");
            shoppingList.Add("Pay Day 3");
            shoppingList.Add("Dead Island 2");
            shoppingList.Add("The Edler Scrolls 6");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }

            shoppingList.Remove("The Edler Srolls 6");
            shoppingList.RemoveAt(1);

            Console.WriteLine("---------------");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }

            // warten vor den schließen
            Console.ReadKey();
        }
        
    }
}