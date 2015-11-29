using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Math.Converter
{
    [TestClass]
    public class HexToBinaryTests
    {
        [TestMethod]
        public void ConvertIt_Passabc123_returnsHex()
        {
            Assert.AreEqual("1010 1011 1100 0001 0010 0011 ", HexToBinary.ConvertIt("abc123"));
        }
        [TestMethod]
        public void ConvertIt1_Passabc123_returnsHex()
        {
            Assert.AreEqual("1010 1011 1100 0001 0010 0011 ", HexToBinary.ConvertIt1("abc123"));
        }
    }
}
