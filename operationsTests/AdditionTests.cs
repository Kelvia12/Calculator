using Microsoft.VisualStudio.TestTools.UnitTesting;
using operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace operations.Tests
{
    [TestClass()]
    public class AdditionTests
    {
        private readonly int a = 2;
        private readonly int b = 5;
        private readonly double c = 8.5;
        private readonly double d = 11.5;
        private readonly double[] arrayA = { 1.01, 2.01, 3, 4.07, 5, 6, 7, 8, 9, 10 };
        private readonly int[] arrayB = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

        [TestMethod()]
        public void SumTest()
        {

            Assert.AreEqual(7, Addition.Sum(a, b));
        }

        [TestMethod()]
        public void SumDoubleTest1()
        {
            Assert.AreEqual(20, Addition.Sum(c, d));
        }

        [TestMethod()]
        public void SumDoubleArrayTest()
        {
            Assert.AreEqual(55.09, Addition.Sum(arrayA));
        }

        [TestMethod()]
        public void SumIntArrayTest()
        {
            Assert.AreEqual(110, Addition.Sum(arrayB));
        }

    }
}