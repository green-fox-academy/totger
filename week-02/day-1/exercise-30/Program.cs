using System;

namespace GreenFox
{
	class Program
	{
		static void Main(string[] args)
		{
			// Write a program that reads a number from the standard input, then draws a
			// diamond like this:
			//
			//
			//    *
			//   ***
			//  *****
			// *******
			//  *****
			//   ***
			//    *
			//
			// The diamond should have as many lines as the number was

			int input = Convert.ToInt32(Console.ReadLine());
            if (input % 2 != 0)
                DrawOdd(input);
            else
                DrawEven(input);

		}

        public static void DrawOdd(int input)
        {
			for (int i = 0; i < input / 2 + 1; i++)
			{

				for (int spaceNum = i; spaceNum < input / 2 + 1; spaceNum++)
				{
					Console.Write(" ");

				}
				for (int starNum = 0; starNum <= i * 2; starNum++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			for (int i = input / 2; i > 0; i--)
			{
				for (int spaceNum = input / 2; spaceNum > i - 2; spaceNum--)
				{
					Console.Write(" ");
				}
				for (int starNum = i * 2 - 1; starNum > 0; starNum--)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
        }
        public static void DrawEven(int input)
        {
			for (int i = 0; i < input / 2; i++)
			{

				for (int spaceNum = i; spaceNum < input / 2 + 1; spaceNum++)
				{
					Console.Write(" ");

				}
				for (int starNum = 0; starNum <= i * 2; starNum++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			for (int i = input / 2; i > 0; i--)
			{
				for (int spaceNum = input / 2; spaceNum > i - 2; spaceNum--)
				{
					Console.Write(" ");
				}
				for (int starNum = i * 2 - 1; starNum > 0; starNum--)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			} 
        }
    }
}