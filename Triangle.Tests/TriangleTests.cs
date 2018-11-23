/* 
 * Programmer:      Randy Lefebvre
 * Course Code:     INFO2180
 * Solution:        Assign02
 * Project:         Triangle.Tests.cs
 * Description:     This project holds all the test for the methods in the "Triangle" project.
 *                  These tests were ran and conducted using the Test Driven Development method.
 *                  The tests were created first, and then followed by the code in Triangle.cs to
 *                  pass these tests.
 * 
 */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleUI;

namespace TriangleUI.Tests
{
    [TestClass]
    public class TriangleTests
    {
        // /////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Testing the function FindHypotenuseOfRight for normal values. 
        /// Test Passed.
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
        /// Testing the function FindHypotenuseOfRight for boundary values. 
        /// Test Passed.
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
        /// Testing the function FindAreaOfRight for normal values. 
        /// Test Passed.
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
        /// Testing the function FindAreaOfRight for boundary values. 
        /// Test Passed.
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
        /// Testing the function FindMissingAngle for normal values. 
        /// Test Passed.
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
        /// <summary>
        /// Testing the function FindMissingAngle for boundary values. 
        /// Test Passed.
        /// </summary>
        [TestMethod]
        [TestCategory("FindMissingAngle")]
        [TestCategory("Boundary")]
        public void FindMissingAngleBoundary()
        {
            var triangle = new Triangle();
            double angle3 = triangle.FindMissingAngle(100, 100);
            Assert.AreEqual(-1, angle3);
        }
    }
}
