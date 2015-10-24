using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Use binary to determine if an integer is positive or negative
    //Note: C# uses arithmetic right shifting which retains the sign-bit.
    //Arithmetic right shifting (>>) a positive number (or zero) by 31 results in in 0.
    //Arithmetic right shifting (>>) a negative number by 31 results in -1
    //Arithmetic right shifting (>>) zero by 31 results in 0.
    //Arithmetic right shifting 8 (1000) results in 4 (100), repeating results in 2 (10), repeating results in 1 (1), repeating results in 0. 
    //Arithmetic right shifting -8 (11111111111111111111111111111000) results in -4 (11111111111111111111111111111100), repeating results in -2 (11111111111111111111111111111110), repeating results in -1 (11111111111111111111111111111111)
    //Effectively, the result of arithmetic right shifting a signed integer by a single bit is equivalent to dividing it by 2.
    //Source: Ace Programming Interview p. 336
    public static class IsNegative
    {
        public static bool IsItNegative(int x)
        {
            if (x == 0)
                throw new Exception("Zero is neither positive or negative");
            int i = (x >> 31);
            return ((i & 1) == 1);
        }
    }
}