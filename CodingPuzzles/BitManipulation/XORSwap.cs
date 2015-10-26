using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Swap two integer variables without using a third variable as a temporary storage container
    //Source: Alex Armstrong - http://www.i-programmer.info/babbages-bag/498-the-magic-swap.html
    //How XOR works (swapping 8 and 5):
    //Step 1: x = x ^ y;
    //Step 2: y = x ^ y;
    //Step 3: x = x ^ y;
    //////////////////////////Step 1:
    // result = 8 ^ 5
    // 8      (00001000)
    // 5      (00000101)
    // result (00001101) (13 in base10)
    /////////////////////////Step 2:
    // result = 13 ^ 5
    // 13     (00001101)
    // 5      (00000101)
    // result (00001000) ( 8 in base10)
    ////////////////////////Step 3:
    // result = 13 ^ 8
    // 13     (00001101)
    // 8      (00001000)
    // result (00000101) (5 in base 10)
    //XOR Truth Table
    // A B Output
    // 0 0 0
    // 1 0 1
    // 0 1 1
    // 1 1 0
    public static class XORSwap
    {
        public static void XORSwapper(ref int x, ref int y)
        {
            x = x ^ y;
            y = x ^ y;
            x = x ^ y;
        }
    }
}
