using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word in the string.
    //If the last word does not exist, return 0.
    //Source: https://leetcode.com/problems/length-of-last-word/
    public static class LengthOfLastWord
    {
        public static int GetLength(string s)
        {
            //Copy passed string to an array and reverse it
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);

            //Returns 0 if there are any spaces after the last word, otherwise returns number of characters in last word in string
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ' ')
                    return count;
                else
                    count++;
            }
            return count;
        }

        //More concise
        public static int GetLength2(string x)
        {
            int length = 0;
            for (int i = x.Length - 1; i >= 0; i--)
            {
                if (x[i] == ' ')
                    return length;
                length++;
            }
            return length;
            //Console.WriteLine(LengthOfLastWord.GetLength("abc abc abc abce "));}
        }
    }
}