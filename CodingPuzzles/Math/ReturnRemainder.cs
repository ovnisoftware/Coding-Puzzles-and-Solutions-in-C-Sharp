using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Write a function that accepts two integers and returns the remainder
    //Source: Ace Programming Interview p. 349
    //Need to handle System.DivideByZeroException
    //Need to handle case where the dividend (x) is less than the divisor (y)
    public class ReturnRemainder
    {
        public static int GetRemainder(int x, int y)
        {
            if (y == 0)
                throw new Exception("Can not divide by zero");

            if (x < y)
                throw new Exception("Number being divided (dividend) can not be less than the divisor");

            return (x % y);
        }
    }
}