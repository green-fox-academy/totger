﻿using System;

namespace GreenFox
{
	class Program
	{
		static void Main(string[] args)
		{
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %   %
            // %   %
            // %   %
            // %   %
            // %%%%%
            //
            // The square should have as many lines as the number was

            int lines = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < lines; i++)
                {
                    Console.Write("%");
                }
            Console.WriteLine();
			for (int i = 0; i < lines - 2; i++)
			{
                Console.Write("%");
                for (int j = 0; j < lines - 2; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("%");
                Console.WriteLine();
            }
			for (int i = 0; i < lines; i++)
			{
				Console.Write("%");
			}
        }
	}
}