using System;

namespace NumberAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddNumber(6));
            Console.ReadLine();
        }

        private static int AddNumber(int n)
        {
            if (n == 0) return 0;
            n += AddNumber(n - 1);
            return n;
        }
    }
}
