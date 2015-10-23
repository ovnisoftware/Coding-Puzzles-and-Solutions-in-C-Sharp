using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.StringManipulation
{
    [TestClass]
    public class IsPalindromeTests
    {
        [TestMethod]
        public void IsItPalindrome_PalindromePassed_ReturnsTrue()
        {
            Assert.IsTrue(IsPalindrome.IsItPalindrome("Never odd or even"));
        }
        [TestMethod]
        public void IsItPalindrome_PalindromePassed1_ReturnsTrue()
        {
            Assert.IsTrue(IsPalindrome.IsItPalindrome("Anna"));
        }
        [TestMethod]
        public void IsItPalindrome_NonPalindromePassed_ReturnsFalse()
        {
            Assert.IsFalse(IsPalindrome.IsItPalindrome("testing"));
        }
        [TestMethod]
        public void IsItPalindrome_EmptyStringPassed_ReturnsTrue()
        {
            Assert.IsTrue(IsPalindrome.IsItPalindrome(""));
        }
    }
}
