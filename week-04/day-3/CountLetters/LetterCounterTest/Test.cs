using NUnit.Framework;
using System;
using System.Collections.Generic;
using CountLetters;

namespace LetterCounterTest
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
            Letters letters = new Letters();
            Dictionary<char, int> output = new Dictionary<char, int>(){
                {'a', 2},
                {'l', 1},
                {'m', 1}
            };

            Assert.AreEqual(output, letters.LetterCounter("alma"));
        }
    }
}
