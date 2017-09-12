using System;

namespace Factorio
{
	class Program
	{
		static void Main(string[] args)
		{
            // - Create a function called `factorio`
            //   that returns it's input's factorial
            Console.WriteLine(Factorio(5));
		}

        public static int Factorio(int input)
        {
            for (int i = input; i > 1; i--)
            {
                input *= (i - 1);
            }
            return input;
        }
    }
}