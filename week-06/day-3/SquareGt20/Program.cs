using System;
using System.Linq;

namespace SquareGt20
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] n = { 3, 9, 2, 8, 6, 5 };

            var output = GetSquareLambda(n);
            var outputQuery = GetSquareQuery(n);
        }

        private static object GetSquareQuery(int[] n)
        {
            return
                from number in n
                where number * number > 20
                select number;
        }

        private static object GetSquareLambda(int[] n)
        {
            return n.Where(x => x * x > 20);
        }
    }
}
