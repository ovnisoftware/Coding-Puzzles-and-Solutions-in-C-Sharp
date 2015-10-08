using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Use bitwise operators to determine whether an integer is a power of 2
    //Source: Ace the Programming Interview p. 312, 337
    public static class IsPowerOf2
    {
        //Doesn't use bitwise operators, but works
        //Any power of 2 in binary is a 1 followed by 0's, so convert int to string and check for a 1 followed by all zeros
        public static bool IsPowerA(int x)
        {
            if (x <= 0)
                return false;

            //Converts integer to binary string
            string binaryString = Convert.ToString(x, 2);

            //Removes first character from string which will always be 1
            binaryString = binaryString.Remove(0, 1);

            //Checks each digit after first is 1, if any are 1 the integer isn't a power of 2
            foreach (char c in binaryString)
            {
                if (c == '1')
                    return false;
            }
            return true;
        }

        //Any power of 2 in binary is a 1 followed by 0's
        //One less than any power of 2 is a 0 followed by all 1's
        //& computes the logical bitwise AND of its operands.
        //8 (1000) & 7 (0001)
        //1000 & 0001 = 0000
        public static bool IsPowerB(int x)
        {
            //0 will return true if you don't check it explicitly because 0 in binary is still 0
            if (x <= 0)
                return false;
            return ((x & (x - 1)) == 0);
        }
    }
}