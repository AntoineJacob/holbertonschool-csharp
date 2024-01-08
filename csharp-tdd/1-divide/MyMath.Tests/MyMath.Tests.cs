using NUnit.Framework;
using MyMath;
namespace MyMath.Tests
{
    public class Tests
    {

        [Test]
        public void Division()
        {
            int[,] matrix = new int[,] { { 5, 4, 3 }, { 2, 1, 7 } };
            Assert.AreEqual(MyMath.Matrix.Divide(matrix, 1), matrix);
        }
        [Test]
        public void DivisionBy0()
        {
            int[,] matrix = new int[,] { { 5, 4, 3 }, { 2, 1, 7 } };
            Assert.AreEqual(MyMath.Matrix.Divide(matrix, 0), null);
        }
        [Test]
        public void MatrixNull()
        {
            int[,] matrix = null;
            Assert.AreEqual(MyMath.Matrix.Divide(matrix, 0), null);
        }
    }
}