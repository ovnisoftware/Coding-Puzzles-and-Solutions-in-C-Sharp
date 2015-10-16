using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //You are given two sorted arrays, A and B, where A has a large enough buffer at the end to hold B.  Write a method to merge B into A in sorted order.
    //Source: Cracking the Coding Interview 5th Edition p. 121
    public static class MergeSortedArrays
    {
        //x array is assumed to be the length of x + y, and lastX is the position of the last stored element in x array
        public static int[] MergeArrays(int[] x, int[] y, int lastX)
        {
            int xIndex = lastX;
            int yIndex = y.Length - 1;
            int mergeIndex = x.Length - 1;
            while (yIndex >= 0)
            {
                if (y[yIndex] > x[xIndex])
                {
                    x[mergeIndex] = y[yIndex];
                    yIndex--;
                }
                else if (y[yIndex] < x[xIndex])
                {
                    x[mergeIndex] = x[xIndex];
                    xIndex--;
                }
                mergeIndex--;
            }
            return x;
        }
    }
}