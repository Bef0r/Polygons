using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polygons.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polygons.Helper.Tests
{
    [TestClass()]
    public class InputCheckerTests
    {
        [TestMethod()]
        public void NumberOfVerticesOfPolygonCheckerTest()
        {
            Assert.IsFalse( InputChecker.NumberOfVerticesOfPolygonChecker("2"));
            Assert.IsFalse(InputChecker.NumberOfVerticesOfPolygonChecker("a"));
            Assert.IsFalse(InputChecker.NumberOfVerticesOfPolygonChecker("?"));
            Assert.IsFalse(InputChecker.NumberOfVerticesOfPolygonChecker("A"));
            Assert.IsFalse(InputChecker.NumberOfVerticesOfPolygonChecker("1"));
            Assert.IsTrue(InputChecker.NumberOfVerticesOfPolygonChecker("3"));
            Assert.IsTrue(InputChecker.NumberOfVerticesOfPolygonChecker("10"));
        }
    }
}