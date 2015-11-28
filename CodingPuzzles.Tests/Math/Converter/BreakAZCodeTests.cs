using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Math.Converter
{
    [TestClass]
    public class BreakAZCodeTests
    {
        [TestMethod]
        public void Encode_Passtest_returns20051920()
        {
            Assert.AreEqual("20051920", BreakAZCode.Encode("test"));
        }
        [TestMethod]
        public void Decode_Pass20051920_returnstest()
        {
            Assert.AreEqual("test", BreakAZCode.Decode("20051920"));
        }
    }
}
