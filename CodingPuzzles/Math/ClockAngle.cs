﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Given a time (hour and minute) find out the acute angle between the two hands.
    //Helpful explanation here: https://www.youtube.com/watch?v=3gbt_EHRRPQ
    public static class ClockAngle
    {
        public static double GetClockAngle(double hr, double min)
        {
            //Calculate hour position between the current hour and the next hour
            double hrAngle = 0;
            if (hr == 12)
                hrAngle = (min * .5);
            else
                hrAngle = (min * .5) + (hr * (360 / 12));

            double minAngle = min * 6;
            double answer = Math.Abs(hrAngle - minAngle);

            //If angle is obtuse (>180), then convert it to an acute angle by subtracting it from 360
            answer = Math.Min(answer, 360 - answer);
            return answer;
        }
        ////Call this in Program.cs to test
        //Console.WriteLine(ClockAngle.GetClockAngle(12, 30));
        ////Output should be 165
    }
}