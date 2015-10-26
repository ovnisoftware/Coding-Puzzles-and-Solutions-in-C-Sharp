using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.StringManipulation
{
    [TestClass]
    public class SingleSpaceTests
    {
        [TestMethod]
        public void ConvertToSingleSpace_PassedMultipleSpaceWords_ReturnsSingleSpaced()
        {
            string input = " hello          world   ";
            string correct = "hello world";
            Assert.AreEqual(correct, SingleSpace.ConvertToSingleSpace(input));
        }
        [TestMethod]
        public void ConvertToSingleSpace_PassedMultipleSpaces_ReturnsEmptyString()
        {
            string input = "         ";
            string correct = "";
            Assert.AreEqual(correct, SingleSpace.ConvertToSingleSpace(input));
        }
    }
}
