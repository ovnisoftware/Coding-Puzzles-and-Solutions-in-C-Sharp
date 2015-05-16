using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Find the uncoupled integer in a given array
    //Ex.  { 2, 5, 2, 3, 7, 3, 5, 9, 9 } returns 7
    public static class Find_Uncoupled_Ints
    {
        public static int ReturnInt(int[] x)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();

            for (int i = 0; i < x.Length; i++)
            {
                if (d.ContainsKey(x[i]))
                    d[x[i]]++;
                else
                    d.Add(x[i], 1);
            }
            foreach (KeyValuePair<int, int> entry in d)
            {
                if (entry.Value == 1)
                    return entry.Key;
            }
            return -1;
        }
    }
    //Run this in Program.cs to test
    //int[] a = new int[] { 2, 5, 2, 3, 7, 3, 5, 9, 9 };
    //Console.WriteLine(Find_Uncoupled_Ints.ReturnInt(a));
    //Output should be 7
}