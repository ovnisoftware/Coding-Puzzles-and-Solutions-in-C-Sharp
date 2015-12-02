using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPuzzles.Tests.Math
{
    [TestClass]
    public class ClockAngleTests
    {
        [TestMethod]
        public void GetClockAngle_Passed1230_Returns165()
        {
            Assert.AreEqual(165, ClockAngle.GetClockAngle(12, 30));
        }
        [TestMethod]
        public void GetClockAngle_Passed1200_Returns0()
        {
            Assert.AreEqual(0, ClockAngle.GetClockAngle(12, 0));
        }
        [TestMethod]
        public void GetClockAngle_Passed630_Returns15()
        {
            Assert.AreEqual(15, ClockAngle.GetClockAngle(6, 30));
        }
        [TestMethod]
        public void GetClockAngle_Passed415_Returns37Point5()
        {
            Assert.AreEqual(37.5, ClockAngle.GetClockAngle(4, 15));
        }
        [TestMethod]
        public void GetClockAngle_PassednegativeHour_ThrowsException()
        {
            Exception exception = null;
            try
            {
                ClockAngle.GetClockAngle(-5,30);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
        [TestMethod]
        public void GetClockAngle_PassednegativeMinute_ThrowsException()
        {
            Exception exception = null;
            try
            {
                ClockAngle.GetClockAngle(5, -30);
            }
            catch (Exception ex)
            {
                exception = ex;
            }
            Assert.IsNotNull(exception);
        }
    }
}
