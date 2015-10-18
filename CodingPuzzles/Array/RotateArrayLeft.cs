using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    public static class RotateArrayLeft
    {
        //Rotate array to the left given a pivot
        //Source: http://www.mycodeschool.com/problems/rotate-a-list
        public static int[] Rotate(int[] x, int pivot)
        {
            if (pivot == 0)
                return x;

            if (pivot > x.Length - 1)
                throw new Exception("Pivot out of range");

            //Rotate first half
            x = RotateSub(x, 0, pivot - 1);

            //Rotate second half
            x = RotateSub(x, pivot, x.Length - 1);

            //Rotate all
            x = RotateSub(x, 0, x.Length - 1);

            return x;
        }

        private static int[] RotateSub(int[] x, int start, int end)
        {
            while (start < end)
            {
                int temp = x[start];
                x[start] = x[end];
                x[end] = temp;
                start++;
                end--;
            }
            return x;
        }
        //int[] x = new int[] { 1, 2, 3, 4, 5 };
        //x = RotateArrayLeft.Rotate(x, 2);
        //foreach (int i in x)
        //    Console.WriteLine(i);
    }
}