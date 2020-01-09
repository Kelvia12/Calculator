using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticsCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatisticsCalculator.Tests
{
    [TestClass()]
    public class StatisticCalculatorTests
    {
        [TestMethod()]
        public void MeanTest()
        {
            StatisticCalculator statsCal = new StatisticCalculator();
            int[] values = { 1, 2 };
            var mean = statsCal.Mean(values);
            Assert.AreEqual(1.5, mean);
        }
    }
}