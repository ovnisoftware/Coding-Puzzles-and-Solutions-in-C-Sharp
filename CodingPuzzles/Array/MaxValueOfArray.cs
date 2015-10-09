using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Write a function to return the maximum value stored in an array of non-negative integers
    public static class MaxValueInArray
    {
        public static int GetMax(params int[] input)
        {
            if (input.Length == 0)
                throw new Exception("Empty Array");

            int max = 0;
            foreach (int i in input)
            {
                if (i > max)
                    max = i;
            }
            return max;
        }
    }
}