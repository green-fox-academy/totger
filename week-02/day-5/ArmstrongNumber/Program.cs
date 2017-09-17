using System;
//using System.Math;

namespace ArmstrongNumber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double number = GetNumber();
            Console.WriteLine(Math.Floor(Math.Log10(number) + 1));
        }

        private static double GetNumber()
        {
            Console.WriteLine("Type in a number:");
            double input = Convert.ToDouble(Console.ReadLine());
            return input;
        }
    }
}
