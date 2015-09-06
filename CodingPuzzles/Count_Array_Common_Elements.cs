using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    public static class Count_Array_Common_Elements
    {
        //Count the number of elements that two arrays have in common
        public static int NumCommonElements(int[] arr1, int[] arr2)
        {
            int result = 0;
            List<int> list = new List<int>();

            //Iterate through the first array, storing only one instance of each integer in case there are duplicates
            foreach (int x in arr1)
                if (!list.Contains(x))
                    list.Add(x);

            //Iterate through the second array, if the list contains the integer from the second array, remove it from the list
            //in case it's in the second array more than once
            foreach (int x in arr2)
                if (list.Contains(x))
                {
                    result++;
                    list.Remove(x);
                }
            return result;
        }
        ////Run in Program.cs to test
        //int[] z = new int[] { 5, 5, 5, 4, 3, 2, 1 };
        //int[] y = new int[] { 9, 3, 3, 3, 2, 2, 2, 1 };
        //Console.WriteLine(Count_Array_Common_Elements.NumCommonElements(z, y));
        ////Output should be 3
    }
}