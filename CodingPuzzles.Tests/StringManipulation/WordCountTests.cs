using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.StringManipulation
{
    [TestClass]
    public class WordCountTests
    {
        [TestMethod]
        public void Count_Passed13Words_Returns13()
        {
            string input = "   a  b   c   d    e   f   g  hij   k   l  m   no   p  ";
            Assert.AreEqual(13, WordCount.Count(input));
        }
        [TestMethod]
        public void Count_Passed0Words_Returns0()
        {
            string input = "    ";
            Assert.AreEqual(0, WordCount.Count(input));
        }
        [TestMethod]
        public void Count_PassedEmptyString_Returns0()
        {
            string input = "";
            Assert.AreEqual(0, WordCount.Count(input));
        }
    }
}
