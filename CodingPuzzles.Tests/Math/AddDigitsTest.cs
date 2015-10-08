using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Math
{
    [TestClass]
    public class AddDigitsTest
    {
        [TestMethod]
        public void Add_PositiveIntPassed_ReturnsSingleDigitInt()
        {
            int x = AddDigits.Add(38);
            Assert.AreEqual(1, x.ToString().Length);
        }
        [TestMethod]
        public void Add_LargePositiveIntPassed_ReturnsSingleDigitInt()
        {
            int x = AddDigits.Add(28923848);
            Assert.AreEqual(1, x.ToString().Length);
        }
    }
}
