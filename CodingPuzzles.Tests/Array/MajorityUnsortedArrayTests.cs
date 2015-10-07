using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Array
{
    [TestClass]
    public class MajorityUnsortedArrayTests
    {
        [TestMethod]
        public void GetMajorityElement_2IsMajorityElement_Returns2()
        {
            int[] x = new int[] { 10, 9, 8, 7, 6, 4, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
            Assert.AreEqual(2, MajorityUnsortedArray.GetMajorityElement(x));
        }
        [TestMethod]
        public void GetMajorityElement_NoMajorityElement_ThrowsException()
        {
            Exception exception = null;
            try
            {
                int[] x = new int[] { 10, 9, 8, 7, 6, 4, 3, 2 };
                MajorityUnsortedArray.GetMajorityElement(x);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
    }
}
