using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.StringManipulation
{
    [TestClass]
    public class LongestCommonPrefixTests
    {
        [TestMethod]
        public void FindPrefix_PassedFStringArray_Returnsf()
        {
            string[] input = new string[] { "flower", "flow", "fello", "fleet" };
            Assert.AreEqual("f", LongestCommonPrefix.FindPrefix(input));
        }
        [TestMethod]
        public void FindPrefix_PassedFlStringArray_Returnsfl()
        {
            string[] input = new string[] { "flower", "flow", "fleet" };
            Assert.AreEqual("fl", LongestCommonPrefix.FindPrefix(input));
        }
        [TestMethod]
        public void FindPrefix_PassedNoCommonPrefixStringArray_ReturnsEmptyString()
        {
            string[] input = new string[] { "abc", "def", "ghi" };
            Assert.AreEqual("", LongestCommonPrefix.FindPrefix(input));
        }
        [TestMethod]
        public void FindPrefix1_PassedFStringArray_Returnsf()
        {
            string[] input = new string[] { "flower", "flow", "fello", "fleet" };
            Assert.AreEqual("f", LongestCommonPrefix.FindPrefix1(input));
        }
        [TestMethod]
        public void FindPrefix1_PassedFlStringArray_Returnsfl()
        {
            string[] input = new string[] { "flower", "flow", "fleet" };
            Assert.AreEqual("fl", LongestCommonPrefix.FindPrefix1(input));
        }
        [TestMethod]
        public void FindPrefix1_PassedNoCommonPrefixStringArray_ReturnsEmptyString()
        {
            string[] input = new string[] { "abc", "def", "ghi" };
            Assert.AreEqual("", LongestCommonPrefix.FindPrefix1(input));
        }
    }
}
