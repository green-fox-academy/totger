using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The seconf represents the number of pigs the farmer has
            // It should print how many legs all the animals have

            Console.Write("Add meg hany csirkeje van a gazdanak: ");
            int numberOfChicken = Convert.ToInt32(Console.ReadLine());

            Console.Write("Add meg hany malaca van a gazdanak: ");
            int numberOfPigs = Convert.ToInt32(Console.ReadLine());

            int totalLegs = numberOfPigs * 4 + numberOfChicken * 2;

            Console.WriteLine("A gazda allatainak osszesen " + totalLegs + " laba van");
        }

    }
}