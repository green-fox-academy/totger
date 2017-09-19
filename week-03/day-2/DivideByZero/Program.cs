using System;

namespace DivideByZero
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			// create a function that takes a number
			// divides ten with it,
			// and prints the result.
			// it should print "fail" if the parameter is 0
			Divider();
        }
        public static void Divider()
        {
            Console.WriteLine("Type in the number that you want to divide 10 with");

            try
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine(10 / input);
            }

            catch (DivideByZeroException)
			{
				Console.WriteLine("Are you really trying to divide by zero, mate?");
			}
            catch (FormatException)
			{
				Console.WriteLine("wtf?");
			}
        }
    }
}
