using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Write a program that reverses an array.  Ex. ({ 7, 4, 9, 2 } becomes { 2, 9, 4, 7 })
    //without calling Array.Reverse() in System namespace
    public static class ReverseArray
    {
        public static void Reverse(int[] x)
        {
            int[] reversed = new int[x.Length];

            //Make sure to subtract 1 from the array length because an array containing 2 elements will have a length of two
            //but the first element is at the 1 index, accessing the 2 index will result in an IndexOutOfRangeException
            for (int i = 0; i < x.Length; i++)
                reversed[i] = x[x.Length - 1 - i];

            //Overwrites passed array with reversed array
            reversed.CopyTo(x, 0);
        }
    }
}