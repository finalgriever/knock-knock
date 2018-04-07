using Microsoft.VisualStudio.TestTools.UnitTesting;
using KnockKnock.Models;
using KnockKnock.Exceptions;

namespace KnockKnockTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void ATriangleWithAllEqualSidesReturnsTypeEquilateral()
        {
            var triangle = new Triangle(1, 1, 1);
            Assert.AreEqual(Triangle.EQUILATERAL, triangle.Type);
        }

        [TestMethod]
        public void ATriangleWithTwoEqualSidesReturnsTypeIsosceles()
        {
            var triangle = new Triangle(1, 2, 2);
            Assert.AreEqual(Triangle.ISOSCELES, triangle.Type);
        }

        [TestMethod]
        public void ATriangleWithNoEqualSidesReturnsTypeScalene()
        {
            var triangle = new Triangle(4, 5, 6);
            Assert.AreEqual(Triangle.SCALENE, triangle.Type);
        }

        [TestMethod]
        [ExpectedException(typeof(DomainException))]
        public void ATriangleWithOneSideGreaterThanTheSumOfTwoOthersThrowsAnException()
        {
            var triangle = new Triangle(4, 1, 1);
        }

        [TestMethod]
        [ExpectedException(typeof(DomainException))]
        public void ATriangleWithASideSmallerThanOneThrowsAnException()
        {
            var triangle = new Triangle(0, 1, 1);
        }
    }
}
