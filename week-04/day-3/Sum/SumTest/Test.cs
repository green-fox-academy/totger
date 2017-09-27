using NUnit.Framework;
using System;
using System.Collections.Generic;
using Sum;

namespace SumTest
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
            int sum = 8;
            var sumNums = new SumClass();
            List<int> list = new List<int>() {1, 3, 4};

            int output = sumNums.GetSum(list);

            Assert.AreEqual(sum, output);
        }
    }
}
