using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Find the uncoupled integer in a given array
    //Ex.  { 2, 5, 2, 3, 7, 3, 5, 9, 9 } returns 7
    public static class FindUncoupledInts
    {
        public static int GetUncoupled(int[] x)
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
            throw new Exception("No uncoupled integer in array");
        }
    }
}