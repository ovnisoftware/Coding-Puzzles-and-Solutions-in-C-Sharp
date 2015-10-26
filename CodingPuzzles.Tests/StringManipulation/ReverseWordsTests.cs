using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.StringManipulation
{
    [TestClass]
    public class ReverseWordsTests
    {
        [TestMethod]
        public void Reverse_PassString_ReturnsReverse()
        {
            string input = " word ";
            string correct = "word";
            Assert.AreEqual(correct, ReverseWords.Reverse(input));
        }
        [TestMethod]
        public void Reverse_PassEmptyString_ReturnsEmptyString()
        {
            string input = "";
            string correct = "";
            Assert.AreEqual(correct, ReverseWords.Reverse(input));
        }
        [TestMethod]
        public void Reverse_PassWordsWithMultipleSpaces_ReturnsReversedStringSingleSpaced()
        {
            string input = " it   is     big    ";
            string correct = "big is it";
            Assert.AreEqual(correct, ReverseWords.Reverse(input));
        }
    }
}
