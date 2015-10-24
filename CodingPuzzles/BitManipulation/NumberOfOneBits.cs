using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Write a function that takes an unsigned integer and returns the number of ’1' bits it has
    //Source: https://leetcode.com/problems/number-of-1-bits/
    //Source: http://stackoverflow.com/questions/109023/how-to-count-the-number-of-set-bits-in-a-32-bit-integer
    //AND (&) Operator Truth Table
    //A B Output
    //0 0 0
    //1 0 0
    //0 1 0
    //1 1 1
    public class NumberOfOneBits
    {
        public static int NumBits(uint input)
        {
            int count = 0;
            while (input > 0) // until all bits are zero
            {
                if ((input & 1) == 1)     // check lower bit (rightmost bit)
                    count++;
                input >>= 1;              // shift bits, removing lower bit  Ex. 100 (8 in decimal) becomes 10 (4 in decimal)
            }
            return count;
        }
    }
}