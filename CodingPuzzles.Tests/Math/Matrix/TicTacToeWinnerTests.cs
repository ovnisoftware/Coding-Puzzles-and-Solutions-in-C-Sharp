using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Math.Matrix
{
    [TestClass]
    public class TicTacToeWinnerTests
    {
        [TestMethod]
        public void IsWinner_PassWinningBoard_ReturnsTrue()
        {
            int[,] a = new int[3, 3];
            a[0, 0] = 0;
            a[0, 1] = 0;
            a[0, 2] = 0;
            a[1, 0] = 1;
            a[1, 1] = 1;
            a[1, 2] = 1;
            a[2, 0] = 0;
            a[2, 1] = 0;
            a[2, 2] = 0;
            Assert.IsTrue(TicTacToeWinner.IsWinner(a));
        }
        [TestMethod]
        public void IsWinner_PassInvalidInput_ThrowsException()
        {
            Exception exception = null;
            try
            {
                int[,] a = new int[3, 3];
                a[0, 0] = 0;
                a[0, 1] = 0;
                a[0, 2] = 0;
                a[1, 0] = 5; //Invalid value
                a[1, 1] = 1;
                a[1, 2] = 1;
                a[2, 0] = 0;
                a[2, 1] = 0;
                a[2, 2] = 0;
                Assert.IsTrue(TicTacToeWinner.IsWinner(a));
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
    }
}
