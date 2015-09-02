using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    public static class Selection_Sort
    {
        //Selection Sort
        //Write a program that traverses an array of integers, identifies the smallest integer
        //and swaps it with the element at the far left in the zero index position.
        //The program then will traverse the remainder of the array
        //(excluding the first position which is already sorted) and repeat the process
        //Selection Sort time complexity
        //Best case: O(n^2)
        //Average case: O(N^2)
        //Worst case: O(N^2)
        public static int[] SelectionSort(params int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                int minPos = i;
                for (int k = i + 1; k < x.Length; k++)
                {
                    if (x[minPos] > x[k])
                        minPos = k;
                }
                //Smallest elements in the array are swapped with the elements to the farthest left
                if (i != minPos)
                {
                    int temp = x[i];
                    x[i] = x[minPos];
                    x[minPos] = temp;
                }
            }
            return x;
        }
        ////Call Program.cs to test
        //int[] x = Selection_Sort.SelectionSort(4,3,2,1);
        //foreach (int y in x)
        //    Console.WriteLine(y);
        ////Output should be:
        ////1
        ////2
        ////3
        ////4
    }
}
