using System;
using System.Collections.Generic;
using System.Linq;

namespace MatrixSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> matrix = new List<List<int>>()
            {
                new List<int>() { 1, 2, 3},
                new List<int>() { 2, 3, 4},
                new List<int>() { 1, 1, 1}
            };
            Console.WriteLine(SumLists(matrix));
        }

        public static int SumLists(List<List<int>> matrix)
        {
            return matrix.Select(x => x.Sum()).Sum();
        }
    }
}
