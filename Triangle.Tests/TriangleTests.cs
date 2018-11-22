using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void FindHypotenuseTest()
        {
            var triangle = new Triangle();
            int hyp = triangle.FindHypotenuseOfRight(4, 3);
            Assert.AreEqual(5, hyp);
        }
    }
}
