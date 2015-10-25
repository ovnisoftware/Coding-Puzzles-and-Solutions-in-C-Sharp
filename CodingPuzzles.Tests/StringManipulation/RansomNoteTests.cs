using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.StringManipulation
{
    [TestClass]
    public class RansomNoteTests
    {
        [TestMethod]
        public void RansomNoteCanBeFormedChars_CanBeFormed_ReturnsTrue()
        {
            string note = "aabb";
            string mag = "aaabb";
            Assert.IsTrue(RansomNote.RansomNoteCanBeFormedChars(note, mag));
        }
        [TestMethod]
        public void RansomNoteCanBeFormedChars_CanNotBeFormed_ReturnsFalse()
        {
            string note = "abc";
            string mag = "aaabb";
            Assert.IsFalse(RansomNote.RansomNoteCanBeFormedChars(note, mag));
        }
        [TestMethod]
        public void RansomNoteCanBeFormedWords_CanBeFormed_ReturnsTrue()
        {
            string note = "  they   to  ";
            string mag = "        two    systems are talking to each other, they always need to specify what encoding      ";
            Assert.IsTrue(RansomNote.RansomNoteCanBeFormedWords(note, mag));
        }
        [TestMethod]
        public void RansomNoteCanBeFormedWords_CanNoteBeFormed_ReturnsFalse()
        {
            string note = "  they  to  can ";
            string mag = "        two    systems are talking to each other, they always need to specify what encoding      ";
            Assert.IsFalse(RansomNote.RansomNoteCanBeFormedWords(note, mag));
        }
    }
}
