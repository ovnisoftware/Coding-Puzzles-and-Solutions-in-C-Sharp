using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Math
{
    [TestClass]
    public class FactorialRecursiveTests
    {
        [TestMethod]
        public void GetFactorial_Passed6_Returns720()
        {
            Assert.AreEqual(720, FactorialRecursive.GetFactorial(6));
        }
        [TestMethod]
        public void GetFactorial_Passed0_Returns1()
        {
            Assert.AreEqual(1, FactorialRecursive.GetFactorial(0));
        }
        [TestMethod]
        public void GetFactorial_Passed2_Returns2()
        {
            Assert.AreEqual(2, FactorialRecursive.GetFactorial(2));
        }
        [TestMethod]
        public void GetFactorial_Passed1_Returns1()
        {
            Assert.AreEqual(1, FactorialRecursive.GetFactorial(1));
        }
        [TestMethod]
        public void GetFactorial_PassedNegative5_ThrowsException()
        {
            Exception exception = null;
            try
            {
                FactorialRecursive.GetFactorial(-5);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
    }
}
