using System;
using System.Collections.Generic;
using System.Linq;

namespace Frequency
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] n = { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var output = GetFrequencyLambda(n);
        }

        private static Dictionary<int, int> GetFrequencyLambda(int[] n)
        {
            Dictionary<int, int> output = new Dictionary<int, int>();
            var uniqueNumbers = n.Distinct();

            foreach (var number in uniqueNumbers)
            {
                output.Add(number, n.Count(x => x == number));
            }

            return output;
        }
    }
}
