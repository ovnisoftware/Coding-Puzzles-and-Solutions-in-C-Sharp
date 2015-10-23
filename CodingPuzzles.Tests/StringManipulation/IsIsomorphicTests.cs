using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.StringManipulation
{
    [TestClass]
    public class IsIsomorphicTests
    {
        [TestMethod]
        public void IsoCheck_IsomorphicPassed_ReturnsTrue()
        {
            Assert.IsTrue(IsIsomorphic.IsoCheck("egg", "add"));
        }
        [TestMethod]
        public void IsoCheck_IsomorphicPassed1_ReturnsTrue()
        {
            Assert.IsTrue(IsIsomorphic.IsoCheck("paper", "title"));
        }
        [TestMethod]
        public void IsoCheck_NonIsomorphicPassed_ReturnsFalse()
        {
            Assert.IsFalse(IsIsomorphic.IsoCheck("aba", "bbb"));
        }
        [TestMethod]
        public void IsoCheck_NonIsomorphicPassed1_ReturnsFalse()
        {
            Assert.IsFalse(IsIsomorphic.IsoCheck("foo", "bar"));
        }
    }
}
