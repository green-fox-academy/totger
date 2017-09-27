using System;
using System.Collections.Generic;

namespace Sum
{
    public class SumClass
    {
        List<int> list = new List<int>();
        public int GetSum(List<int> list)
        {
            int sum = 0;
            foreach (int num in list)
            {
                sum += num;
            }
            return sum;
        }
    }
}
