using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Array
{
    [TestClass]
    public class RotateArrayLeftTests
    {
        [TestMethod]
        public void Rotate_RotateArray_ReturnsRotatedArray()
        {
            int[] x = new int[] { 1, 2, 3, 4, 5 };
            x = RotateArrayLeft.Rotate(x, 2);
            int[] correct = new int[] { 3, 4, 5, 1, 2 };
            CollectionAssert.AreEqual(correct, x);
        }
        [TestMethod]
        public void Rotate_Passed0_ReturnsOriginalArray()
        {
            int[] x = new int[] { 1, 2, 3, 4, 5 };
            x = RotateArrayLeft.Rotate(x, 0);
            int[] correct = new int[] { 1, 2, 3, 4, 5 };
            CollectionAssert.AreEqual(correct, x);
        }
        [TestMethod]
        public void Rotate_PassedNegative_ThrowsException()
        {
            Exception exception = null;
            try
            {
                int[] x = new int[] { 1, 2, 3, 4, 5 };
                x = RotateArrayLeft.Rotate(x, -5);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
        [TestMethod]
        public void Rotate_PassedIndexMoreThanLength_ThrowsException()
        {
            Exception exception = null;
            try
            {
                int[] x = new int[] { 1, 2, 3, 4, 5 };
                x = RotateArrayLeft.Rotate(x, 6);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
    }
}
