using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        [TestCategory("Normal")]
        public void FindHypotenuseTestNormal()
        {
            var triangle = new Triangle();
            double hyp = triangle.FindHypotenuseOfRight(4, 3);
            Assert.AreEqual(5, hyp);
        }
        [TestMethod]
        [TestCategory("Boundary")]
        public void FindHypotenuseTestBoundary()
        {
            var triangle = new Triangle();
            double hyp = triangle.FindHypotenuseOfRight(0 , -1);
            Assert.AreEqual(-1, hyp);
        }

        //[TestMethod]
    }
}
