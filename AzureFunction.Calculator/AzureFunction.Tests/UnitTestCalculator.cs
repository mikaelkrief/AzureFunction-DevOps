using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AzureFunction.Tests
{
    [TestClass]
    public class UnitTestCalculator
    {
        [TestMethod]
        public void TestAdd()
        {
            int a = 5;
            int b = 5;

            int res = AzureFunction.Calculator.Calculator.Add(a, b);
            Assert.AreEqual(res, 10);
        }

        [TestMethod]
        public void TestSubstract()
        {
            int a = 15;
            int b = 10;

            int res = AzureFunction.Calculator.Calculator.Substract(a, b);
            Assert.AreEqual(res, 5);
        }
    }
}
