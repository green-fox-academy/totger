using System;

namespace GreenFox
{
	class Program
	{

        static void Main(string[] args)
        {
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8

            int random = GenerateNumber();
            while (!HigherOrLower(random))
            {
               Console.WriteLine("Make your guess!");
            }
            Console.WriteLine("You found the number {0}", random);

        }

        private static int GenerateNumber()
        {
            return new Random().Next(0,100);
        }

        private static bool HigherOrLower(int random)
        {
            
            int userGuess = Convert.ToInt32(Console.ReadLine());

            if (userGuess < random)
            {
                Console.WriteLine("The stored number is higher");
                return false;
            }
            else if (userGuess > random)
            {
                Console.WriteLine("The stored number is lower");
                return false;
            }

            return true;
        }
    }
}