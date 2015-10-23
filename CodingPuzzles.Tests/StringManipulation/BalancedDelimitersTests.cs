using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.StringManipulation
{
    [TestClass]
    public class BalancedDelimitersTests
    {
        [TestMethod]
        public void IsBalanced_BalancedDelimitersPassed_ReturnsTrue()
        {
            Assert.IsTrue(BalancedDelimiters.IsBalanced("(test)[1234]{testagain!}"));
        }
        [TestMethod]
        public void IsBalanced_BalancedDelimitersPassed1_ReturnsTrue()
        {
            Assert.IsTrue(BalancedDelimiters.IsBalanced("{([])}"));
        }
        [TestMethod]
        public void IsBalanced_BalancedDelimitersPassed2_ReturnsTrue()
        {
            Assert.IsTrue(BalancedDelimiters.IsBalanced("{[]{()}}"));
        }
        [TestMethod]
        public void IsBalanced_EmptyStringPassed_ReturnsTrue()
        {
            Assert.IsTrue(BalancedDelimiters.IsBalanced(""));
        }
        [TestMethod]
        public void IsBalanced_OneClosingDelimiterPassed_ReturnsFalse()
        {
            Assert.IsFalse(BalancedDelimiters.IsBalanced("}"));
        }
        [TestMethod]
        public void IsBalanced_OneOpeningDelimiterPassed_ReturnsFalse()
        {
            Assert.IsFalse(BalancedDelimiters.IsBalanced("{"));
        }
    }
}
