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
            var outputQuery = GetFrequencyQuery(n);
        }

        private static Dictionary<int, int> GetFrequencyQuery(int[] n)
        {
            return
                (from number in n
                group number by number into o
                select new { o.Key, Value = o.Count() })
                .ToDictionary(x => x.Key, x => x.Value);
        }

        private static Dictionary<int, int> GetFrequencyLambda(int[] n)
        {
            Dictionary<int, int> output = new Dictionary<int, int>();

            foreach (var number in n.Distinct())
            {
                output.Add(number, n.Count(x => x == number));
            }
           
            return output;
        }
    }
}
