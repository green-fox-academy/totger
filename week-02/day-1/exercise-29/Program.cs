using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
			// Write a program that reads a number from the standard input, then draws a
			// pyramid like this:
			//
			//
			//    *
			//   ***
			//  *****
			// *******
			//
			// The pyramid should have as many lines as the number was

			Console.WriteLine("Enter a number:");

            int row = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < row; i++)
            {
                for (int spaceNum = i; spaceNum < row; spaceNum++)
                {
                    Console.Write(" ");
                }
                for (int starNum = 0; starNum <= i * 2; starNum++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Number of stars: {0}", row * row);
        }
    }
}