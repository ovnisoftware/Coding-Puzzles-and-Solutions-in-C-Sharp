using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Write a method to sort the elements of an array in descending order
    public static class SortDesc
    {
        public static void Sort(int[] x)
        {
            Array.Sort(x);
            Array.Reverse(x);
        }
        ////Call in Program.cs to test
        //int[] x = new int[] { 7, 3, 2, 4, 5, 1, 8, 6 };
        //Sort_Desc.Sort(x);
        //foreach(int i in x)
        //    Console.WriteLine(i);
    }
}
