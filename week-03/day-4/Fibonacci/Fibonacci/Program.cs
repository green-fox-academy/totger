using System;

namespace Fibonacci
{
    class Program
    {
       
        static void Main(string[] args)
        {
         
            Console.WriteLine(GetFibonacci(8));
            Console.ReadLine();
        }

        private static int GetFibonacci(int n)
        {
            if (n <= 1) return 0;
            if (n == 2) return 1;
         
            return GetFibonacci(n - 1) + GetFibonacci(n - 2);   
        }
    }
}
