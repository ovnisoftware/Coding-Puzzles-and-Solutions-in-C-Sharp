using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Use bitwise operators to determine if an integer is even
    //If an integer is odd, the farthest right bit will always be set to 1
    //Ex. 7 (111)
    //If an integer is even, the farthest right bit will always be set to 0
    //Ex. 8 (1000)
    //AND Truth Table
    //A B Output
    //0 0 0
    //1 0 0
    //0 1 0
    //1 1 1
    public static class CheckParity
    {
        public static bool IsEven(int x)
        {
            //0 & 1 == 0
            //Since the last bit in an even number is 0, this will return true with an even number

            return ((x & 1) == 0);
        }
        public static bool IsOdd(int x)
        {
            // 1 & 1 == 1
            //Since the last bit in an odd number is 1, this will return true with an odd number
            return ((x & 1) == 1);
        }
    }
}
