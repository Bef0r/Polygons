using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polygons.Business_Logics.CoordinateSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polygons.Business_Logics.CoordinateSystem.Tests
{
    [TestClass()]
    public class DistanceBetweenTwoPointTests
    {
        [TestMethod()]
        public void calculateDistanceBetweenTwoPointTest()
        {
            Assert.AreEqual(DistanceBetweenTwoPoint.calculateDistanceBetweenTwoPoint(0, 0, 0, 1), 1);
            Assert.AreEqual(DistanceBetweenTwoPoint.calculateDistanceBetweenTwoPoint(5, 0, 0, 0), 5);
            Assert.AreEqual(DistanceBetweenTwoPoint.calculateDistanceBetweenTwoPoint(10, 4, 3, 0), 8,0622577482985);
            
        }
    }
}