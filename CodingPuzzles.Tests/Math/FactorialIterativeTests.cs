using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Math
{
    [TestClass]
    public class FactorialIterativeTests
    {
        [TestMethod]
        public void GetFactorial_Passed6_Returns720()
        {
            Assert.AreEqual(720, Factorial.GetFactorial(6));
        }
        [TestMethod]
        public void GetFactorial_Passed0_Returns1()
        {
            Assert.AreEqual(1, Factorial.GetFactorial(0));
        }
        [TestMethod]
        public void GetFactorial_PassedNegative5_ThrowsException()
        {
            Exception exception = null;
            try
            {
                Factorial.GetFactorial(-5);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
    }
}
