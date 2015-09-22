using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    class Majority_Unsorted_Array
    {
        //Find majority element in an unsorted array
        //Ex. {1,2,3,4,5,2,2,2,2}, 2 is the majority element because it accounts for more than 50% of the array
        //Source: https://www.youtube.com/watch?v=zOyOwDEF1Rc
        public static int GetMajorityElement(params int[] x)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            int majority = x.Length / 2;

            //Stores the number of occcurences of each item in the passed array in a dictionary
            foreach (int i in x)
                if (d.ContainsKey(i))
                {
                    d[i]++;
                    //Checks if element just added is the majority element
                    if (d[i] > majority)
                        return i;
                }
                else
                    d.Add(i, 1);
            //No majority element
            return -1;
        }
        ////Run in Program.cs to test
        //int[] x = new int[] { 10, 9, 8, 7, 6, 4, 3, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 };
        //int i = Majority_Unsorted_Array.GetMajorityElement(x);
        //Console.WriteLine(i);
    }
}