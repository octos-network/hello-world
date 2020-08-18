using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test");

            Random numberGen = new Random();

            int roll = 0;
            int attempts = 0;

            while(roll != 80) {
                roll = numberGen.Next(1, 81);
                Console.WriteLine("You rolled: " + roll);
                attempts++;
            }

            Console.WriteLine("It took you " + attempts + " attempts to roll a eighty");

            // warten vor den schließen
            Console.ReadKey();
        }
        
    }
}