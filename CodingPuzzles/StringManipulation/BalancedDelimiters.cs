using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Check a string for balanced delimiters
    //Ex. string "(test)[1234]{testagain!}" should return True since it's balanced "()[]{}"
    //"{([])}" is also balanced
    //"{[]{()}}" is also balanced
    public static class BalancedDelimiters
    {
        //This implementation ignores characters that aren't openers or closers, and compares openers and closers on a stack
        public static bool IsBalanced(string input)
        {
            Stack<char> stack = new Stack<char>();
            char[] openers = new char[] { '{', '(', '[' };
            char[] closers = new char[] { '}', ')', ']' };

            foreach (char c in input)
            {
                if (openers.Contains(c))
                    stack.Push(c);

                else if (closers.Contains(c))
                {
                    //Check if an ending delimiter is added before a starting delimiter
                    if (stack.Count == 0)
                        return false;

                    //Check that closer matches opener
                    char compare = stack.Pop();
                    if ((c == '}' && compare != '{') ||
                    (c == ')' && compare != '(') ||
                    (c == ']' && compare != '['))
                        return false;
                }
            }
            return (stack.Count == 0);
        }
    }
}