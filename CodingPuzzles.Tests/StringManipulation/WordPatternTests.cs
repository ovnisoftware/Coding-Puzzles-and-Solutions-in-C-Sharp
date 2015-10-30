using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.StringManipulation
{
    [TestClass]
    public class WordPatternTests
    {
        [TestMethod]
        public void IsPatternMatch_MatchingPattern_ReturnsTrue()
        {
            Assert.IsTrue(WordPattern.IsPatternMatch("abba", "dog cat cat dog"));
        }
        [TestMethod]
        public void IsPatternMatch_EmptyStringPattern_ReturnsTrue()
        {
            Assert.IsTrue(WordPattern.IsPatternMatch("", ""));
        }
        [TestMethod]
        public void IsPatternMatch_NoPattern_ReturnsFalse()
        {
            Assert.IsFalse(WordPattern.IsPatternMatch("abba", "dog cat dog cat"));
        }
}
}
