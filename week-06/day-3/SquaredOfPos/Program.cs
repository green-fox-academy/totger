using System;
using System.Linq;

namespace SquaredOfPos
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var squares = GetSquareLambda(n);
            var squaresQuery = GetSquareQuery(n);
        }

        private static object GetSquareQuery(int[] n)
        {
            return
                from number in n
                where number >= 0
                select number * number;
        }

        private static object GetSquareLambda(int[] n)
        {
            return n.Where(x => x >= 0).Select(x => x * x);
        }
    }
}
