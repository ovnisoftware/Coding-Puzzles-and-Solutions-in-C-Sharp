using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Math
{
    [TestClass]
    public class CheckPrimeTests
    {
        [TestMethod]
        public void IsPrime_NegativeNumberPassed_ReturnsFalse()
        {
            Assert.IsFalse(CheckPrime.IsPrime(-5));
        }
        [TestMethod]
        public void IsPrime_2Passed_ReturnsTrue()
        {
            Assert.IsTrue(CheckPrime.IsPrime(2));
        }
        [TestMethod]
        public void IsPrime_1Passed_ReturnsFalse()
        {
            Assert.IsFalse(CheckPrime.IsPrime(1));
        }
        [TestMethod]
        public void IsPrime_PrimeIntPassed_ReturnsTrue()
        {
            Assert.IsTrue(CheckPrime.IsPrime(17));
        }
    }
}
