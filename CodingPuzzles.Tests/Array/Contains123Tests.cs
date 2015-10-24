using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Array
{
    [TestClass]
    public class Contains123Tests
    {
        [TestMethod]
        public void Contains123_PassedArrayContaining123_ReturnsTrue()
        {
            Assert.IsTrue(Array123.Contains123(5, 4, 1, 2, 3));
        }
        [TestMethod]
        public void Contains123_PassedArrayNotContaining123_ReturnsFalse()
        {
            Assert.IsFalse(Array123.Contains123(5, 4, 1, 2, 2));
        }
        [TestMethod]
        public void Contains123_PassedEmptyArray_ReturnsFalse()
        {
            Assert.IsFalse(Array123.Contains123());
        }
    }
}
