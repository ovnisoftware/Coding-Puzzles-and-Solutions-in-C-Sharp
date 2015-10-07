using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    public static class CountArrayCommonElements
    {
        //Count the number of elements that two arrays have in common
        public static int GetNumberCommonElements(int[] arr1, int[] arr2)
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
    }
}