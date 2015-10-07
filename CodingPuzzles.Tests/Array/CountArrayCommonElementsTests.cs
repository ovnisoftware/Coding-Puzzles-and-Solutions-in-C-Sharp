using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Array
{
    [TestClass]
    public class CountArrayCommonElementsTests
    {
        [TestMethod]
        public void GetNumberCommonElements_3CommonElements_Returns3()
        {
            int[] z = new int[] { 5, 5, 5, 4, 3, 2, 1 };
            int[] y = new int[] { 9, 3, 3, 3, 2, 2, 2, 1 };
            Assert.AreEqual(3, CountArrayCommonElements.GetNumberCommonElements(z, y));
        }
        [TestMethod]
        public void GetNumberCommonElements_NoCommonElements_Returns0()
        {
            int[] z = new int[] { 15, 15, 15, 14, 13, 12, 11 };
            int[] y = new int[] { 9, 3, 3, 3, 2, 2, 2, 1 };
            Assert.AreEqual(0, CountArrayCommonElements.GetNumberCommonElements(z, y));
        }
        [TestMethod]
        public void GetNumberCommonElements_EmptyArraysPassed_Returns0()
        {
            int[] z = new int[] {  };
            int[] y = new int[] {  };
            Assert.AreEqual(0, CountArrayCommonElements.GetNumberCommonElements(z, y));
        }
    }
}
