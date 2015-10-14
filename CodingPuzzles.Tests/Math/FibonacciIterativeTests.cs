using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Math
{
    [TestClass]
    public class FibonacciIterativeTests
    {
        [TestMethod]
        public void GetFibonacci_Passed7_Returns13()
        {
            Assert.AreEqual(13, FibonacciIterative.GetFibonacci(7));
        }
        [TestMethod]
        public void GetFibonacci_Passed1_Returns1()
        {
            Assert.AreEqual(1, FibonacciIterative.GetFibonacci(1));
        }
        [TestMethod]
        public void GetFibonacci_Passed3_Returns2()
        {
            Assert.AreEqual(2, FibonacciIterative.GetFibonacci(3));
        }
        [TestMethod]
        public void GetFibonacci_Passed0_ThrowsExecption()
        {
            Exception exception = null;
            try
            {
                FibonacciIterative.GetFibonacci(0);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
        [TestMethod]
        public void GetFibonacci_PassedNegative5_ThrowsExecption()
        {
            Exception exception = null;
            try
            {
                FibonacciIterative.GetFibonacci(-5);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
    }
}
