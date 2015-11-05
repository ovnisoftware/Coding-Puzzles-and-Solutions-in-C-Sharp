using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.StringManipulation
{
    [TestClass]
    public class ReverseStringTests
    {
        [TestMethod]
        public void Reverse_PassedEmptyString_ReturnsEmptyString()
        {
            Assert.AreEqual("", ReverseString.Reverse(""));
        }
        [TestMethod]
        public void Reverse_Passedabc_Returnscba()
        {
            Assert.AreEqual("cba", ReverseString.Reverse("abc"));
        }
    }
}
