using System;

namespace GreenFox
{
	class Program
	{
		static void Main(string[] args)
		{
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5

            Console.WriteLine("Please enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please enter the second number:");
			int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2)
            {
                Console.WriteLine("The second number should be bigger");
            }
            else
            {
                Console.WriteLine();
                for (int i = num1; i <= num2; i++)
                    Console.WriteLine(i);
            }
		}
	}
}