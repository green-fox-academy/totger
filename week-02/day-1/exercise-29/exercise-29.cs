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
			for (int i = 1; i <= row; i++)
			{
				for (int j = i; j <= row; j++)
				{
					Console.Write(" ");
				}
				for (int k = 1; k <= i; k++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
        }
    }
}