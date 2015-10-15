using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Math.Converter
{
    [TestClass]
    public class IntToWordsTests
    {
        [TestMethod]
        public void ConvertInt_50000Passed_ReturnsFiftyThousand()
        {
            Assert.AreEqual("Fifty Thousand", IntToWords.ConvertInt(50000));
        }
        [TestMethod]
        public void ConvertInt_0Passed_ReturnsZero()
        {
            Assert.AreEqual("Zero", IntToWords.ConvertInt(0));
        }
        [TestMethod]
        public void ConvertInt_1000010Passed_ReturnsOneMillionTen()
        {
            Assert.AreEqual("One Million Ten", IntToWords.ConvertInt(1000010));
        }
        [TestMethod]
        public void ConvertInt_123Passed_ReturnsOneHundredTwentyThree()
        {
            Assert.AreEqual("One Hundred Twenty Three", IntToWords.ConvertInt(123));
        }
        [TestMethod]
        public void ConvertInt_123000Passed_ReturnsOneHundredTwentyThreeThousand()
        {
            Assert.AreEqual("One Hundred Twenty Three Thousand", IntToWords.ConvertInt(123000));
        }
        [TestMethod]
        public void ConvertInt_Negative5Passed_ThrowsException()
        {
            Exception exception = null;
            try
            {
                IntToWords.ConvertInt(-5);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
    }
}
