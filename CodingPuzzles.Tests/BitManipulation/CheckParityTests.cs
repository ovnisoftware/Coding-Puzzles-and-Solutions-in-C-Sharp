using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.BitManipulation
{
    [TestClass]
    public class CheckParityTests
    {
        [TestMethod]
        public void IsEven_EvenNumberPassed_ReturnsTrue()
        {
            Assert.IsTrue(CheckParity.IsEven(2));
        }
        [TestMethod]
        public void IsEven_OddNumberPassed_ReturnsFalse()
        {
            Assert.IsFalse(CheckParity.IsEven(7));
        }
        [TestMethod]
        public void IsOdd_OddNumberPassed_ReturnsTrue()
        {
            Assert.IsTrue(CheckParity.IsOdd(7));
        }
        [TestMethod]
        public void IsOdd_EvendNumberPassed_ReturnsFalse()
        {
            Assert.IsFalse(CheckParity.IsOdd(2));
        }
    }
}
