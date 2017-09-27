using NUnit.Framework;
using System;
using Fibonacci;

namespace FibonacciTest
{
    [TestFixture()]
    public class Test
    {
        Fibo fibo = new Fibo();

        [Test()]
        public void TestCase()
        {
            int output = 1;

            Assert.AreEqual(output, fibo.GetFibonacci(2));

        }
    }
}
