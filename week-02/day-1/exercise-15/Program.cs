using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it
            Console.Write("Adj meg egy tavolsagot km-ben!");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Az altalad megadott tavolsag merfoldben :" + userInput * 1.60934);
        }
    }
}