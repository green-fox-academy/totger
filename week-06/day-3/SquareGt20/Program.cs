using System;
using System.Linq;

namespace SquareGt20
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };
            var output = GetSquare(n);
        }

        private static object GetSquare(int[] n)
        {
            return n.Where(x => x * x > 20);
        }
    }
}
