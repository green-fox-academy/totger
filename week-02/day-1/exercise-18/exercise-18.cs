using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number form the standard input,
            // Than prints "Odd" if the number is odd, or "Even" it it is even.

            Console.WriteLine("Adj meg egy szamot!");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput % 2 == 0)
            {
                Console.WriteLine("A szam paros");
            }
            else
            {
                Console.WriteLine("A szam paratlan");
            }

        }
    }
}