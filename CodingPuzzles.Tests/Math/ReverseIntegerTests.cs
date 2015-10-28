using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Math
{
    [TestClass]
    public class ReverseIntegerTests
    {
        [TestMethod]
        public void Reverse_Passed0_Returns0()
        {
            Assert.AreEqual(0, ReverseInteger.Reverse(0));
        }
        [TestMethod]
        public void Reverse_Passed10_Returns1()
        {
            Assert.AreEqual(1, ReverseInteger.Reverse(10));
        }

        [TestMethod]
        public void Reverse_Passed123_Returns321()
        {
            Assert.AreEqual(321, ReverseInteger.Reverse(123));
        }
        [TestMethod]
        public void Reverse_PassedNegative123_ReturnsNegative321()
        {
            Assert.AreEqual(-321, ReverseInteger.Reverse(-123));
        }
        [TestMethod]
        public void Reverse_Passed2147483647_ThrowsException()
        {
            Exception exception = null;
            try
            {
                ReverseInteger.Reverse(2147483647);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
        [TestMethod]
        public void Reverse_PassedNegative2147483648_ThrowsException()
        {
            Exception exception = null;
            try
            {
                ReverseInteger.Reverse(-2147483648);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
    }
}