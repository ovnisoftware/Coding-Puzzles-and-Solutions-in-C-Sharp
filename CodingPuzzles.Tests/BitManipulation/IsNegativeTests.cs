using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.BitManipulation
{
    [TestClass]
    public class IsNegativeTests
    {
        [TestMethod]
        public void IsItNegative_NegativeNumberPassed_ReturnsTrue()
        {
            Assert.IsTrue(IsNegative.IsItNegative(-5));
        }
        [TestMethod]
        public void IsItNegative_PositveNumberPassed_ReturnsFalse()
        {
            Assert.IsFalse(IsNegative.IsItNegative(5));
        }
        [TestMethod]
        public void IsItNegative_ZeroPassed_ThrowsException()
        {
            Exception exception = null;
            try
            {
                IsNegative.IsItNegative(0);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
    }
}
