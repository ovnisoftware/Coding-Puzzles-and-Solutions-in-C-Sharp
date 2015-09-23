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
        public static int GetMax(int[] input)
        {
            //If an empty array is passed, -1 will be returned
            int max = -1;

            foreach (int i in input)
            {
                if (i > max)
                    max = i;
            }
            return max;
        }
        //int[] input = new int[] { 0, 58, 8, 92, 194, 2 };
        //Console.WriteLine(MaxValueInArray.GetMax(input));
        ////Should return 194
    }
}