using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.BitManipulation
{
    [TestClass]
    public class BinaryCountTests
    {
        [TestMethod]
        public void NumNoConsecutiveOnes_Passed3_Returns5()
        {
            Assert.AreEqual(5, BinaryCount.NumNoConsecutiveOnes(3));
        }
        [TestMethod]
        public void NumNoConsecutiveOnes_Passed1_Returns2()
        {
            Assert.AreEqual(2, BinaryCount.NumNoConsecutiveOnes(1));
        }
        [TestMethod]
        public void NumNoConsecutiveOnes_PassedNumberLessThan1_ThrowsException()
        {
            Exception exception = null;
            try
            {
                BinaryCount.NumNoConsecutiveOnes(0);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
    }
}
