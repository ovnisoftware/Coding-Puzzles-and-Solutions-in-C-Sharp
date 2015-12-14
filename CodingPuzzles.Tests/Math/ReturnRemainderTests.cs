using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Math
{
    [TestClass]
    public class ReturnRemainderTests
    {
        [TestMethod]
        public void GetRemainder_Pass10and2_Returns0()
        {
            Assert.AreEqual(0, ReturnRemainder.GetRemainder(10, 2));
        }
        [TestMethod]
        public void GetRemainder_Pass100and2_Returns0()
        {
            Assert.AreEqual(0, ReturnRemainder.GetRemainder(100, 2));
        }
        [TestMethod]
        public void GetRemainder_Pass10and3_Returns1()
        {
            Assert.AreEqual(1, ReturnRemainder.GetRemainder(10, 3));
        }
        [TestMethod]
        public void GetRemainder_Pass10and10_Returns0()
        {
            Assert.AreEqual(0, ReturnRemainder.GetRemainder(10, 10));
        }
        [TestMethod]
        public void GetRemainder_DivideByZero_ThrowsException()
        {
            Exception exception = null;
            try
            {
                ReturnRemainder.GetRemainder(10, 0);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
        [TestMethod]
        public void GetRemainder_XLessThanY_ThrowsException()
        {
            Exception exception = null;
            try
            {
                ReturnRemainder.GetRemainder(4, 10);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
    }
}
