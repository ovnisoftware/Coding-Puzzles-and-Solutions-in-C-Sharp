using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.StringManipulation
{
    [TestClass]
    public class ReplaceSpaceTests
    {
        [TestMethod]
        public void Replace_PassedStringWithSpaceAtEnd_ReturnsOriginalString()
        {
            string correct = "test";
            Assert.AreEqual(correct, ReplaceSpace.Replace("test "));
        }
        [TestMethod]
        public void Replace_PassedStringWith2OuterSpaces_ReturnsOriginalString()
        {
            string correct = "test";
            Assert.AreEqual(correct, ReplaceSpace.Replace(" test "));
        }
        [TestMethod]
        public void Replace_PassedEmptyString_ReturnsEmptyString()
        {
            string correct = ""; ;
            Assert.AreEqual(correct, ReplaceSpace.Replace(""));
        }
        [TestMethod]
        public void Replace_PassedStringWith2InnerSpaces_ReturnsStringWithReplacements()
        {
            string correct = "test%20it%20now"; ;
            Assert.AreEqual(correct, ReplaceSpace.Replace("test it now"));
        }
    }
}
