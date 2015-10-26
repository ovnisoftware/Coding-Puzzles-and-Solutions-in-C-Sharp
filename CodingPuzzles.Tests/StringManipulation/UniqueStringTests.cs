using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.StringManipulation
{
    [TestClass]
    public class UniqueStringTests
    {
        [TestMethod]
        public void IsUnique_UniqueStringPassed_ReturnsTrue()
        {
            Assert.IsTrue(UniqueString.IsUnique("abcdefg"));
        }
        [TestMethod]
        public void IsUnique_NonUniqueStringPassed_ReturnsFalse()
        {
            Assert.IsFalse(UniqueString.IsUnique("abca"));
        }
        [TestMethod]
        public void IsUnique_EmptyStringPassed_ReturnsTrue()
        {
            Assert.IsTrue(UniqueString.IsUnique(""));
        }
        [TestMethod]
        public void IsUnique1_UniqueStringPassed_ReturnsTrue()
        {
            Assert.IsTrue(UniqueString.IsUnique1("abcdefg"));
        }
        [TestMethod]
        public void IsUnique1_NonUniqueStringPassed_ReturnsFalse()
        {
            Assert.IsFalse(UniqueString.IsUnique1("abca"));
        }
        [TestMethod]
        public void IsUnique1_EmptyStringPassed_ReturnsTrue()
        {
            Assert.IsTrue(UniqueString.IsUnique1(""));
        }
    }
}
