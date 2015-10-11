using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Given an array A having positive and negative integers and a number k, find the minimum length sub array of A with sum = k.
    //Source Youtube - IDeserve: https://www.youtube.com/watch?v=gHSoIwnERF0
    public static class SubArraySumK
    {
        public static int GetSubArray(int[] x, int target)
        {
            int minArraySize = int.MaxValue;
            for (int i = 0; i < x.Length; i++)
            {
                int sum = 0;
                int count = 0;
                for (int k = i; k < x.Length; k++)
                {
                    sum += x[k];
                    count++;
                    if ((sum == target) && (count < minArraySize))
                    {
                        minArraySize = count;
                        break;
                    }
                    if (sum > target)
                        break;
                }
            }
            if (minArraySize == int.MaxValue)
                throw new Exception("No sub array amounts to passed value");
            return minArraySize;
        }
        //int[] x = new int[] { 2, 3, 1, 1, -1, 6, 4, 3, 8 };
        //Console.WriteLine(SubArraySumK.GetSubArray(x, 7));
    }
}