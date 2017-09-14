using System;

namespace GreenFox
{
	class Program
	{
		static void Main(string[] args)
		{
            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4

            Console.WriteLine("How many numbers do you want to use?");
            int numberOfNumbers = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            Console.WriteLine("Cool, then type those numbers:");

            for (int i = 0; i < numberOfNumbers; i++)
            {
                double number = Convert.ToDouble(Console.ReadLine());
                sum += number;
            }
            double average = sum / numberOfNumbers;
            Console.WriteLine("BAAAM, there you go: Sum: {0}, Average: {1}",
                              sum, Math.Round(average, 2));

        }
	}
}