using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Array
{
    [TestClass]
    public class TargetSumTests
    {
        [TestMethod]
        public void TwoIntegersSumToTarget_2IntsInPassedArraySumToTarget_ReturnsTrue()
        {
            int[] input = new int[] { 1, 2, 3, 4 };
            Assert.AreEqual(true,TargetSum.TwoIntegersSumToTarget(input, 5));
        }
        [TestMethod]
        public void TwoIntegersSumToTarget_2IntsInPassedArrayDoNotSumToTarget_ReturnsFalse()
        {
            int[] input = new int[] { 1, 2, 3, 4 };
            Assert.AreEqual(false, TargetSum.TwoIntegersSumToTarget(input, 20));
        }
        [TestMethod]
        public void TwoIntegersSumToTarget_EmptyArrayPassed_ReturnsFalse()
        {
            int[] input = new int[] { };
            Assert.AreEqual(false,TargetSum.TwoIntegersSumToTarget(input, 5));
        }
    }
}
