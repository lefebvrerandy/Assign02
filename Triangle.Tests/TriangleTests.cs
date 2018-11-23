using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
    [TestClass]
    public class TriangleTests
    {
        // /////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        [TestCategory("FindHypotenuseOfRight")]
        [TestCategory("Normal")]
        public void FindHypotenuseTestNormal()
        {
            var triangle = new Triangle();
            double hyp = triangle.FindHypotenuseOfRight(4, 3);
            Assert.AreEqual(5, hyp);
        }
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        [TestCategory("FindHypotenuseOfRight")]
        [TestCategory("Boundary")]
        public void FindHypotenuseTestBoundary()
        {
            var triangle = new Triangle();
            double hyp = triangle.FindHypotenuseOfRight(0 , -1);
            Assert.AreEqual(-1, hyp);
        }

        // /////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        [TestCategory("FindAreaOfRight")]
        [TestCategory("Normal")]
        public void FindAreaTestNormal()
        {
            var triangle = new Triangle();
            double area = triangle.FindAreaOfRight(10, 15);
            Assert.AreEqual(75, area);
        }
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        [TestCategory("FindAreaOfRight")]
        [TestCategory("Boundary")]
        public void FindAreaTestBoundary()
        {
            var triangle = new Triangle();
            double area = triangle.FindAreaOfRight(0, 10);
            Assert.AreEqual(-1, area);
        }

        // /////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        [TestCategory("FindMissingAngle")]
        [TestCategory("Normal")]
        public void FindMissingAngleNormal()
        {
            var triangle = new Triangle();
            double angle3 = triangle.FindMissingAngle(38, 100);
            Assert.AreEqual(42, angle3);
        }
    }
}
