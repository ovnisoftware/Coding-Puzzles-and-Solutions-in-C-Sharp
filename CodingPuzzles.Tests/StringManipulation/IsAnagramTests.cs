using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.StringManipulation
{
    [TestClass]
    public class IsAnagramTests
    {
        [TestMethod]
        public void IsItAnagram_AnagramsPassed_ReturnsTrue()
        {
           Assert.IsTrue(IsAnagram.IsItAnagram("listen", "silent"));
        }
        [TestMethod]
        public void IsItAnagram_AnagramsPassed1_ReturnsTrue()
        {
            Assert.IsTrue(IsAnagram.IsItAnagram("abc", "cba"));
        }
        [TestMethod]
        public void IsItAnagram_NonAnagramsPassed_ReturnsFalse()
        {
            Assert.IsFalse(IsAnagram.IsItAnagram("bob", "joe"));
        }
    }
}
