using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            CountDown(10);
            Console.ReadLine();
        }

        private static void CountDown(int n)
        {
            if (n < 0)
                return;
            Console.WriteLine(n);
            CountDown(n - 1);
        }
    }
}
