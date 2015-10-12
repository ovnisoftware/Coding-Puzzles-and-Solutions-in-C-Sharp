using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    public static class Array123
    {
        //Given an array of ints, return true if .. 1, 2, 3, .. appears in the array somewhere.
        //Source: http://codingbat.com/prob/p136041
        public static bool Contains123(params int[] x)
        {
            if (x.Length < 3)
                return false;
            for (int i = 0; i <= x.Length - 3; i++)
            {
                if ((x[i] == 1) &&
                (x[i + 1] == 2) &&
                (x[i + 2] == 3))
                    return true;
            }
            return false;
        }
    }
}