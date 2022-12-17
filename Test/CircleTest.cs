using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using MindboxTest;

namespace Test
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void radiusZeroTest()
        {
            Assert.ThrowsException<ArgumentException>(()=>new Circle(0d));
        }
        [TestMethod]
        public void negativeRadiusTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-1d));
        }
        [TestMethod]
        public void getAreaTest() 
        {
            var radius = 10;
            var circle = new Circle(radius);
            var expValue = Math.PI * Math.Pow(radius, 2d);
            var area = circle.getArea();
            Assert.IsTrue(area == expValue);
        }
    }
}
