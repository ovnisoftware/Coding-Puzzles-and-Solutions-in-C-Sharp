using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Given an integer and an array of integers determine whether any two integers in the array sum to that integer.
    public static class TargetSum
    {
        //Brute force solution, O(n^2) time complexity
        public static bool TwoIntegersSumToTarget(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = i + 1; k < arr.Length; k++)
                {
                    if ((arr[i] + arr[k]) == target)
                        return true;
                }
            }
            return false;
        }
    }
}