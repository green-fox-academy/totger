using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageOfOdds
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            double output = GetAverageOfOddLambda(n);
            double queryOutput = GetAverageOfOddQuery(n);
        }

        private static double GetAverageOfOddQuery(int[] n)
        {
            var odds =
                from number in n
                where number % 2 != 0
                select number;

            return odds.Average();
        }

        private static double GetAverageOfOddLambda(int[] n)
        {
            return n.Where(x => x % 2 != 0).Average();
        }


    }
}
