using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    public static class IsEqual
    {
        //Check equality of two ints using bitwise operators
        //XOR is the same as (!=), hence (x ^ y) will return 0 only for equal values.
        //How XOR works:
        // 5 ^ 5
        // 5      (00000101)
        // 5      (00000101)
        // result (00000000)
        //XOR Truth Table
        // A B Output
        // 0 0 0
        // 1 0 1
        // 0 1 1
        // 1 1 0
        public static bool TwoIntsEqual(int x, int y)
        {
            if ((x ^ y) == 0)
                return true;
            return false;
        }
    }
}