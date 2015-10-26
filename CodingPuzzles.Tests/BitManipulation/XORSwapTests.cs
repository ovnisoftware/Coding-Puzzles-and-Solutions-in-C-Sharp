using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.BitManipulation
{
    [TestClass]
    public class XORSwapTests
    {
        [TestMethod]
        public void XORSwapper_TwoIntsPassed_ReturnsSwappedInts()
        {
            int x = 5;
            int y = 9;
            XORSwap.XORSwapper(ref x, ref y);
            Assert.AreEqual(9, x);
            Assert.AreEqual(5, y);
        }
    }
}
