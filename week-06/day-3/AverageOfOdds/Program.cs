using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageOfOdds
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var output = GetAverageOfOddLambda();
        }

        private static double GetAverageOfOddLambda()
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var average = n.Where(x => x % 2 != 0).Average();

            return average;
        }
    }
}
