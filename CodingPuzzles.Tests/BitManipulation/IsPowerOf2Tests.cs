using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.BitManipulation
{
    [TestClass]
    public class IsPowerOf2Tests
    {
        [TestMethod]
        public void IsPowerA_PowerOf2Passed_ReturnsTrue()
        {
            Assert.IsTrue(IsPowerOf2.IsPowerA(8));
        }
        [TestMethod]
        public void IsPowerA_NonPowerOf2Passed_ReturnsFalse()
        {
            Assert.IsFalse(IsPowerOf2.IsPowerA(7));
        }
        [TestMethod]
        public void IsPowerA_ZeroPassed_ReturnsFalse()
        {
            Assert.IsFalse(IsPowerOf2.IsPowerA(0));
        }
        [TestMethod]
        public void IsPowerA_NegativeIntPassed_ReturnsFalse()
        {
            Assert.IsFalse(IsPowerOf2.IsPowerA(-8));
        }
        [TestMethod]
        public void IsPowerB_PowerOf2Passed_ReturnsTrue()
        {
            Assert.IsTrue(IsPowerOf2.IsPowerB(8));
        }
        [TestMethod]
        public void IsPowerB_NonPowerOf2Passed_ReturnsFalse()
        {
            Assert.IsFalse(IsPowerOf2.IsPowerB(7));
        }
        [TestMethod]
        public void IsPowerB_ZeroPassed_ReturnsFalse()
        {
            Assert.IsFalse(IsPowerOf2.IsPowerB(0));
        }
        [TestMethod]
        public void IsPowerB_NegativeIntPassed_ReturnsFalse()
        {
            Assert.IsFalse(IsPowerOf2.IsPowerB(-8));
        }
    }
}
