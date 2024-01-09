using NUnit.Framework;
using System;
using System.Collections.Generic;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestList()
        {
			List<int> test = new List<int>() {1, 2, 3, 4, 5, 6};

			int result = Operations.Max(test);
			Assert.AreEqual(result, 6);
        }

        [Test]
        public void TestEmptyList()
        {
			List<int> test = new List<int>() {};

			int result = Operations.Max(test);
			Assert.AreEqual(result, 0);
        }

        [Test]
        public void TestSameNumberList()
        {
			List<int> test = new List<int>() {1, 1, 1, 1, 1, 1};

			int result = Operations.Max(test);
			Assert.AreEqual(result, 1);
        }

        [Test]
        public void TestNegativeList()
        {
			List<int> test = new List<int>() {-1, -2, -3, -4, -5, -6};

			int result = Operations.Max(test);
			Assert.AreEqual(result, -1);
        }

        [Test]
        public void TestNegativePositiveList()
        {
			List<int> test = new List<int>() {1, -2, -3, -4, 5, -6};

			int result = Operations.Max(test);
			Assert.AreEqual(result, 5);
		}

        [Test]
        public void TestOneElementList()
        {
			List<int> test = new List<int>() {-6};

			int result = Operations.Max(test);
			Assert.AreEqual(result, -6);
		}

        [Test]
        public void TestZeroList()
        {
			List<int> test = new List<int>() {-6, -5, -3, 0};

			int result = Operations.Max(test);
			Assert.AreEqual(result, 0);
		}

        [Test]
        public void TestNullList()
        {
			var ex = Assert.Throws<NullReferenceException>(() => Operations.Max(null));
			Assert.NotNull(ex);
		}
    }
}