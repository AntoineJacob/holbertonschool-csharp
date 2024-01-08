using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    /// <summary>
    /// public class Tests
    /// </summary>
    public class Tests
    {
        [Test]
        ///<summary>
        ///public void Test1()
        ///</summary>
        public void Test1()
        {
            int a = Operations.Add(1, 9);
            Assert.AreEqual(a, 10);
        }
    }
}