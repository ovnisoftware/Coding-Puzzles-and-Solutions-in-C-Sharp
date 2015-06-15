using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Transform an array of items into a dictionary with each key being the integers found in the array
    //and each value being the number of occurrences of each integer
    //Source: Ace the Programming Interview p. 348
    public static class Transform_Array
    {
        public static Dictionary<int,int> Catalog(int[] x)
        {
            Dictionary <int,int> d = new Dictionary<int,int>();
            foreach(int i in x)
            {
                if (d.ContainsKey(i))
                    d[i]++;
                else
                    d.Add(i, 1);
            }
            return d;
        }
    }
}