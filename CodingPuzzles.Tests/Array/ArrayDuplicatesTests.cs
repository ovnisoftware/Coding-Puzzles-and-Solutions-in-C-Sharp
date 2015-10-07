using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Array
{
    [TestClass]
    public class ArrayDuplicatesTests
    {
        [TestMethod]
        public void ContainsDuplicates_NoDuplicates_ReturnsFalse()
        {
            Assert.IsFalse(ArrayDuplicates.ContainsDuplicates(1, 2, 3, 4, 5));
        }
        [TestMethod]
        public void ContainsDuplicates_Duplicates_ReturnsTrue()
        {
            Assert.IsTrue(ArrayDuplicates.ContainsDuplicates(1, 2, 3, 2));
        }
    }
}
