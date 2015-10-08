using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Math
{
    [TestClass]
    public class DiceTests
    {
        [TestMethod]
        public void Roll_DieRolled_ReturnsBetween1and6()
        {
            Dice die = new Dice();
            int x = die.Roll();
            Assert.IsTrue(x < 7);
            Assert.IsTrue(x > 0);
        }
    }
}
