using System;

namespace GreenFox
{
	class Program
	{
		static void Main(string[] args)
		{
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4

            Console.WriteLine("Adj meg egy szamot! ");
            int num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Adj meg egy szamot! ");
			int num2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Adj meg egy szamot! ");
			int num3 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Adj meg egy szamot! ");
			int num4 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Adj meg egy szamot! ");
			int num5 = Convert.ToInt32(Console.ReadLine());

            double sum = num1 + num2 + num3 + num4 + num5;
            double average = sum / 5;
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);


		}
	}
}