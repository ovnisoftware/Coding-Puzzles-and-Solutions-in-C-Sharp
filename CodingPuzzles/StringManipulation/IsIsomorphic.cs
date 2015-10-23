using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Given two strings s and t, determine if they are isomorphic.
    //Two strings are isomorphic if the characters in s can be replaced to get t.
    //Ex. "egg" and "add" are isomorphic
    //Source: https://leetcode.com/problems/isomorphic-strings/
    public static class IsIsomorphic
    {
        public static bool IsoCheck(string x, string y)
        {
            //Map string x
            //The index of the first occurence of each character will be added to result string, so "add" will be 011.  "bob" will be 010
            Dictionary<int, int> xD = new Dictionary<int, int>();
            char[] xArr = x.ToCharArray();
            string xResult = "";
            for (int i = 0; i < x.Length; i++)
            {
                if (xD.ContainsKey(xArr[i]))
                    xResult += xD[xArr[i]].ToString();
                else
                {
                    xD.Add(xArr[i], i);
                    xResult += i.ToString();
                }
            }

            //Map string y
            Dictionary<int, int> yD = new Dictionary<int, int>();
            char[] yArr = y.ToCharArray();
            string yResult = "";
            for (int i = 0; i < y.Length; i++)
            {
                if (yD.ContainsKey(yArr[i]))
                    yResult += yD[yArr[i]].ToString();
                else
                {
                    yD.Add(yArr[i], i);
                    yResult += i.ToString();
                }
            }
            //Compare strings
            return (yResult == xResult);
        }
    }
}