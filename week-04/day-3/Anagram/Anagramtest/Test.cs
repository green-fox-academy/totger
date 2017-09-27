using NUnit.Framework;
using System;
using Anagram;

namespace AnagramTest
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
            Anagramma anagram = new Anagramma();

            Assert.IsTrue(anagram.IsAnagram("kakao", "okaka"));
        }
    }
}
