using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.BitManipulation
{
    [TestClass]
    public class NumberOfOneBitsTests
    {
        [TestMethod]
        public void NumBits_Passed8_Returns1()
        {
            Assert.AreEqual(1, NumberOfOneBits.NumBits(8));
        }
        [TestMethod]
        public void NumBits_Passed0_Returns10()
        {
            Assert.AreEqual(0, NumberOfOneBits.NumBits(0));
        }
        [TestMethod]
        public void NumBits_Passed5_Returns2()
        {
            Assert.AreEqual(2, NumberOfOneBits.NumBits(5));
        }
        [TestMethod]
        public void NumBits_Passed128_Returns1()
        {
            Assert.AreEqual(1, NumberOfOneBits.NumBits(128));
        }
    }
}
