using System;
namespace Fibonacci
{
    public class Fibo
    {
       public int GetFibonacci(int n)
        {
            if (n == 1) return 0;
            if (n == 2) return 1;
            return GetFibonacci(n-1);
        }
    }
}
