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
    public class Return_Remainder
    {
        public static int CalcRem(int x, int y)
        {
            if ((y == 0) || (x < y))
                //You could alternatively throw an exception here  //throw new NotImplementedException();
                return -1;
            else
                return (x % y);
        }
    }
}