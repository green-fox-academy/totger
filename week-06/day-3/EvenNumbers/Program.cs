using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenNumbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<int> evenNumbers = GetEvenNumbersQuery();
        }

        private static List<int> GetEvenNumbersQuery()
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var evenNumbers =
                from number in n
                where number % 2 == 0
                select number;

            return evenNumbers.ToList<int>();
        }
    }
}
