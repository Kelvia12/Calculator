using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasicCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Calculator calculator = new Calculator();

            int c = calculator.Add(1, 2);

            Assert.AreEqual(3, c);
            Assert.AreEqual(3, calculator.result);

        }
        [TestMethod()]
        public void DivideTest()
        {
            Calculator calculator = new Calculator();

            int c = calculator.Divide(2, 1);

            Assert.AreEqual(2, c);
            Assert.AreEqual(2, calculator.result);

        }

        [TestMethod()]
        public void DivideIntDivideZeroTest()
        {
            Calculator calculator = new Calculator();

            Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(2, 0));
        }

        [TestMethod()]
        public void AddTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DivideTest1()
        {
            Assert.Fail();
        }
    }

}