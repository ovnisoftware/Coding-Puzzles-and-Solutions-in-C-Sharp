using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Array
{
    [TestClass]
    public class SubArraySumKTests
    {
        [TestMethod]
        public void GetMinLength_PassedArrayWithSubArrayOf2_Returns2()
        {
            int[] input = new int[] { 2, 3, 1, 1, -1, 6, 4, 3, 8 };
            Assert.AreEqual(2,SubArraySumK.GetMinLength(input, 7));
        }
        [TestMethod]
        public void GetMinLength_PassedArrayWithNoMatchingSubArray_ThrowsException()
        {
            Exception exception = null;
            try
            {
                int[] input = new int[] { 10, 9, 8, 7, 6, 4, 3, 2 };
                SubArraySumK.GetMinLength(input, 100);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
    }
}
