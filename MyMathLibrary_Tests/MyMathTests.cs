using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMathLibrary;

namespace MyMathLibrary_Tests
{
    [TestClass]
    public class MyMathTests
    {
        [TestMethod]
        public void GetTriangleType_NegativeSides_NotTriangle()
        {
            float a = -1.5f;
            float b = 1.0f;
            float c = 2.0f;

            Geometry.TriangleType expected = Geometry.TriangleType.NotTriangle;
            Assert.AreEqual(expected, GetActualResult(a,b,c));
        }

        [TestMethod]
        public void GetTriangleType_ZeroSide_NotTriangle()
        {
            float a = 0.0f;
            float b = 1.0f;
            float c = 2.0f;

            Geometry.TriangleType expected = Geometry.TriangleType.NotTriangle;
            Assert.AreEqual(expected, GetActualResult(a, b, c));
        }

        [TestMethod]
        public void GetTriangleType_IncorrectSides_NotTriangle()
        {
            float a = 5.0f;
            float b = 2.0f;
            float c = 3.0f;

            Geometry.TriangleType expected = Geometry.TriangleType.NotTriangle;
            Assert.AreEqual(expected, GetActualResult(a, b, c));
        }

        [TestMethod]
        public void GetTriangleType_Right()
        {
            float a = 5;
            float b = 3;
            float c = 4;

            Geometry.TriangleType expected = Geometry.TriangleType.Right;
            Assert.AreEqual(expected, GetActualResult(a, b, c));
        }

        [TestMethod]
        public void GetTriangleType_Obtuse()
        {
            float a = 6;
            float b = 3;
            float c = 4;

            Geometry.TriangleType expected = Geometry.TriangleType.Obtuse;
            Assert.AreEqual(expected, GetActualResult(a, b, c));
        }

        [TestMethod]
        public void GetTriangleType_Acute()
        {
            float a = 4;
            float b = 3;
            float c = 4;

            Geometry.TriangleType expected = Geometry.TriangleType.Acute;
            Assert.AreEqual(expected, GetActualResult(a, b, c));
        }

        private Geometry.TriangleType GetActualResult(float a, float b, float c)
        {
            return Geometry.GetTriangleType(a, b, c);
        }
    }
}
