using NUnit.Framework;
using System.Collections.Generic;
using Extension;

namespace Extension
{
	[TestFixture]
	public class ExtensionTests
	{
		ExtensionClass extension = new ExtensionClass();

		[Test]
		public void TestAdd_2and3is5()
		{
			Assert.AreEqual(5, extension.Add(2, 3));
		}

		[Test]
		public void TestAdd_1and4is5()
		{
			Assert.AreEqual(5, extension.Add(1, 4));
		}

		[Test]
		public void TestMaxOfThree_First()
		{
			Assert.AreEqual(5, extension.MaxOfThree(5, 4, 3));
		}

		[Test]
		public void TestMaxOfThree_Fhird()
		{
			Assert.AreEqual(5, extension.MaxOfThree(3, 4, 5));
		}

		[Test]
		public void TestMedian_Four()
		{
			Assert.AreEqual(5, extension.Median(new List<int>() { 7, 5, 3, 5 }));
		}

		[Test]
		public void TestMedian_Five()
		{
			Assert.AreEqual(3, extension.Median(new List<int>() { 1, 2, 3, 4, 5 }));
		}

		[Test]
		public void TestIsVowel_a()
		{
			Assert.True(extension.IsVowel('a'));
		}

		[Test]
		public void TestIsVowel_u()
		{
			Assert.True(extension.IsVowel('u'));
		}

		[Test]
		public void testTranslate_bemutatkozik()
		{
			Assert.AreEqual("bevemuvutavatkovozivik", extension.Translate("bemutatkozik"));
		}

		[Test]
		public void testTranslate_kolbice()
		{
			Assert.AreEqual("lavagovopuvus", extension.Translate("lagopus"));
		}

		[Test]
		public void TestAdd_4and3is7()
		{
			Assert.AreEqual(7, extension.Add(4, 3));
		}

		[Test]
		public void TestMaxOfThree_Second()
		{
			Assert.AreEqual(5, extension.MaxOfThree(4, 5, 3));
		}

		[Test]
		public void TestMaxOfThree_Third()
		{
			Assert.AreEqual(5, extension.MaxOfThree(3, 4, 5));
		}

		[Test]
		public void TestMedian_FourDifferentValues()
		{
			Assert.AreEqual(2, extension.Median(new List<int>() { 1, 2, 3, 4 }));
		}

		[Test]
		public void TestMedian_Seven()
		{
			Assert.AreEqual(3, extension.Median(new List<int>() { 1, 2, 3, 4, 5, 5, 3 }));
		}
	}
}