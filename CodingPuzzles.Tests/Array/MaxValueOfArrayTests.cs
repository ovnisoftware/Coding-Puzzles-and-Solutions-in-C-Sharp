using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Array
{
    [TestClass]
    public class MaxValueOfArrayTests
    {
        [TestMethod]
        public void GetMax_ArrayWithMaxof194_Returns194()
        {
            int[] input = new int[] { 0, 58, 8, 92, 194, 2 };
            Assert.AreEqual(194, MaxValueInArray.GetMax(input));
        }
        [TestMethod]
        public void GetMax_EmptyArrayPassed_ThrowsException()
        {
            Exception exception = null;
            try
            {
                MaxValueInArray.GetMax();
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
    }
}
