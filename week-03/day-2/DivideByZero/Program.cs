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
            int input = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(10 / input);
            }

            catch (SystemException)
			{
				Console.WriteLine("wtf?");
			}
			//catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Are you really trying to divide by zero, mate?");
            //}

        }
    }
}
