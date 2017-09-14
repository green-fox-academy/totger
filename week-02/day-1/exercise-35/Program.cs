using System;

namespace GreenFox
{
	class Program
	{
		static void Main(string[] args)
		{
            // Crate a program that draws a chess table like this
            //
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            //
            for (int i = 0; i < 8; i++)
            {
                if (i % 2 == 0)
                    Console.Write(" ");
                for (int j = 0; j < 8; j++)
                {
                    if (j % 2 == 0)
                        Console.Write("%");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
	}
}