using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Array
{
    [TestClass]
    public class FindUncoupledIntsTests
    {
        [TestMethod]
        public void GetUncoupled_7IsUnCoupledInt_Returns7()
        {
            int[] arr = new int[] { 2, 5, 2, 3, 7, 3, 5, 9, 9 };
            Assert.AreEqual(7, FindUncoupledInts.GetUncoupled(arr));
        }
        [TestMethod]
        public void GetUncoupled_NoUnCoupledInt_ThrowsException()
        {
            Exception exception = null;
            try
            {
                int[] arr = new int[] { 2, 5, 2, 3, 7, 7, 3, 5, 9, 9 };
                FindUncoupledInts.GetUncoupled(arr);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
    }
}