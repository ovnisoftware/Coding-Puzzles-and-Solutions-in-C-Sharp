using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.StackTests
{
    [TestClass]
    public class ReverseStringWithStackTests
    {
        [TestMethod]
        public void Reverse_Passedabc_Returnscba()
        {
            Assert.AreEqual("cba", ReverseStringWithStack.Reverse("abc"));
        }
        [TestMethod]
        public void Reverse_PassedEmptyString_ReturnsEmptyString()
        {
            Assert.AreEqual("", ReverseStringWithStack.Reverse(""));
        }
    }
}
