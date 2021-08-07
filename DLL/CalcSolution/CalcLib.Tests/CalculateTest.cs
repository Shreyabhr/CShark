using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalcLib.Tests
{
    [TestClass]
    public class CalculateTest
    {
        [TestMethod]
        public void CheckingIFNoIsEven()
        {
            Calculator calc = new Calculator();
            bool expectedValue = false;
            int inputValue = 2;

            bool actualValue = calc.CheckEven(inputValue);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
