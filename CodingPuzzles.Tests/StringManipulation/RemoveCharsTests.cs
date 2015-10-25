using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.StringManipulation
{
    [TestClass]
    public class RemoveCharsTests
    {
        [TestMethod]
        public void Remove_PassedString_ReturnsDelimiters()
        {
            string input = "(test)[1234]{testagain!}";
            string correct = "()[]{}";
            Assert.AreEqual(correct, RemoveChars.Remove(input));
        }
        [TestMethod]
        public void Remove_PassedEmptyString_ReturnsEmptyString()
        {
            string input = "";
            string correct = "";
            Assert.AreEqual(correct, RemoveChars.Remove(input));
        }
    }
}
