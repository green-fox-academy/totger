using NUnit.Framework;
using System;
using Apple;
namespace AppleTest
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
            Apples apple = new Apples();

            Assert.AreEqual("apple", apple.GetApple());
        }
    }
}
