using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Given a pattern and a string str, find if str follows the same pattern
    //Source: https://leetcode.com/problems/word-pattern/
    public static class WordPattern
    {
        public static bool IsPatternMatch(string pattern, string words)
        {
            //Transform pattern into int array Ex. abba becomes 1221
            int[] patternArr = new int[pattern.Length];
            for (int i = 0; i < pattern.Length; i++)
            {
                if (patternArr[i] == 0)
                    patternArr[i] = i + 1;
                for (int k = i + 1; k < pattern.Length; k++)
                {
                    if (pattern[i] == pattern[k])
                        patternArr[k] = i + 1;
                }
            }

            //Put words in passed string in a list
            List<string> wordList = new List<string>();
            foreach (string word in words.Split(' '))
                wordList.Add(word);

            //Transform words into int array Ex. dog cat cat dog becomes 1221
            int[] wordArr = new int[wordList.Count];
            for (int i = 0; i < wordList.Count; i++)
            {
                if (wordArr[i] == 0)
                    wordArr[i] = i + 1;
                for (int k = i + 1; k < wordList.Count; k++)
                {
                    if (wordList[i] == wordList[k])
                        wordArr[k] = i + 1;
                }
            }
            //Check equality
            return patternArr.SequenceEqual(wordArr);
        }
        //Console.WriteLine(WordPattern.IsPatternMatch("abba", "dog cat cat dog"));
    }
}
