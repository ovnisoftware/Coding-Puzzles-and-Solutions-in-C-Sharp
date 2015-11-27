using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Math.Converter
{
    [TestClass]
    public class BinaryToDecimalTests
    {
        [TestMethod]
        public void Convert_Pass1000_Returns8()
        {
            Assert.AreEqual(8, BinaryToDecimal.Convert("1000"));
        }

        [TestMethod]
        public void Convert_Pass10111101_Returns189()
        {
            Assert.AreEqual(189, BinaryToDecimal.Convert("10111101"));
        }

        [TestMethod]
        public void Convert_PassEmptyString_ThrowsException()
        {
            Exception exception = null;
            try
            {
                BinaryToDecimal.Convert("");
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
        [TestMethod]
        public void Convert_PassLetters_ThrowsException()
        {
            Exception exception = null;
            try
            {
                BinaryToDecimal.Convert("abc");
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
        [TestMethod]
        public void Convert_Pass3782_ThrowsException()
        {
            Exception exception = null;
            try
            {
                BinaryToDecimal.Convert("3782");
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
    }
}
