using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter
            Console.WriteLine(Sum(5));

        }
        public static int Sum(int n)
        {
            for (int i = n; i > 0; i--)
            {
                n += i - 1;
            }
            return n;
        }
    }
}