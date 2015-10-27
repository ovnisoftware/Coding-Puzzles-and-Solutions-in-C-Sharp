using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Count binary strings with no consecutive ones 
    //Source: https://www.youtube.com/watch?v=Bq9lgqC1YwE
    public static class BinaryCount
    {
        public static int NumNoConsecutiveOnes(int x)
        {
            if (x < 1)
                throw new Exception("Can not process a length of less than 1");
            if (x == 1)
                return 2;
            if (x == 2)
                return 3;
            return NumNoConsecutiveOnes(x - 1) + NumNoConsecutiveOnes(x - 2);
        }
    }
}
