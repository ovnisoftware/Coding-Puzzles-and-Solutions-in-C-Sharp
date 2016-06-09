using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    public static class test
    {
        public static bool IsBalanced(string input)
        {
            char[] openArr = new char[] { '(', '[', '{' };
            char[] closeArr = new char[] { ')', ']', '}' };
            Stack<char> s = new Stack<char>();

            foreach (char c in input)
            {
                if ((openArr.Contains(c)) || (closeArr.Contains(c)))
                {
                    if ((closeArr.Contains(c)) && (s.Count == 0))
                        return false;
                    else
                        s.Push(c);
                }

                while (s.Count != 0)
                {

                }

                //if (arr.Contains(c))
                //s.Push(c);
            }



            return true;
        }
    }
}
