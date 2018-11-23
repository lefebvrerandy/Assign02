using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        [TestCategory("FindHypotenuseOfRight")]
        [TestCategory("Normal")]
        public void FindHypotenuseTestNormal()
        {
            var triangle = new Triangle();
            double hyp = triangle.FindHypotenuseOfRight(4, 3);
            Assert.AreEqual(5, hyp);
        }
        [TestMethod]
        [TestCategory("FindHypotenuseOfRight")]
        [TestCategory("Boundary")]
        public void FindHypotenuseTestBoundary()
        {
            var triangle = new Triangle();
            double hyp = triangle.FindHypotenuseOfRight(0 , -1);
            Assert.AreEqual(-1, hyp);
        }

        [TestMethod]
        [TestCategory("FindAreaOfRight")]
        [TestCategory("Normal")]
        public void FindAreaTestNormal()
        {
            var triangle = new Triangle();
            double area = triangle.FindAreaOfRight(10, 15);
            Assert.AreEqual(75, area);
        }

    }
}
