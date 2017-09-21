using System;

namespace SumDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a non-negative int n, return the sum of its digits recursively (no loops). 
            // Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6), while 
            // divide (/) by 10 removes the rightmost digit (126 / 10 is 12).
            Console.WriteLine(Digits(12614));
            Console.ReadLine();
        }

        private static int Digits(int n)
        {
            if (n <= 0) return 0;
            n = n % 10 + Digits(n / 10);
            return n;
        }
    }
}
