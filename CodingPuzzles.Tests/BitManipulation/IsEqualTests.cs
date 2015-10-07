using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.BitManipulation
{
    [TestClass]
    public class IsEqualTests
    {
        [TestMethod]
        public void TwoIntsEqual_TwoEqualIntsPassed_ReturnsTrue()
        {
            Assert.IsTrue(IsEqual.TwoIntsEqual(5, 5));
        }
        [TestMethod]
        public void TwoIntsEqual_TwoUnequalIntsPassed_ReturnsFalse()
        {
            Assert.IsFalse(IsEqual.TwoIntsEqual(5, 10));
        }
    }
}
