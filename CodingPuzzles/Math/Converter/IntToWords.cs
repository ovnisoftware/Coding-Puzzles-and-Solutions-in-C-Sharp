using System;
using System.Collections.Generic;

namespace CodingPuzzles
{
    //Convert a non-negative integer to its english words representation. Given input is guaranteed to be less than 2^31 - 1. 
    //Source: https://leetcode.com/problems/integer-to-english-words/
    public static class IntToWords
    {
        //Breaks input into 3 digit chunks and passes each 3 digit chunk to a helper function to convert it into words, uses enums to convert int to string
        public static string ConvertInt(int input)
        {
            if (input < 0)
                throw new Exception("Integer must be positive.");
            if (input == 0)
                return "Zero";

            //Split input into 3 digit chunks
            List<int> ThreeDigitChunks = new List<int>();
            while (input > 0)
            {
                int threeDigits = input % 1000;
                ThreeDigitChunks.Add(threeDigits);
                input /= 1000;
            }

            //Reverse list so it's in same order as the input that was passed
            ThreeDigitChunks.Reverse();

            string result = "";

            //Billions
            if (ThreeDigitChunks.Count == 4)
            {
                result += ConvertLessThanThousand(ThreeDigitChunks[0]) + " Billion ";
                ThreeDigitChunks.RemoveAt(0);
            }

            //Millions
            if (ThreeDigitChunks.Count == 3)
            {
                //Doesn't call helper function if input will be all zeros
                if (ThreeDigitChunks[0] == 0)
                    ThreeDigitChunks.RemoveAt(0);
                else
                {
                    result += ConvertLessThanThousand(ThreeDigitChunks[0]) + " Million ";
                    ThreeDigitChunks.RemoveAt(0);
                }
            }

            //Hundreds of Thousands
            if (ThreeDigitChunks.Count == 2)
            {
                //Doesn't call helper function if input will be all zeros
                if (ThreeDigitChunks[0] == 0)
                    ThreeDigitChunks.RemoveAt(0);
                else
                {
                    result += ConvertLessThanThousand(ThreeDigitChunks[0]) + " Thousand ";
                    ThreeDigitChunks.RemoveAt(0);
                }
            }

            //Hundreds
            //Doesn't call helper function if input will be all zeros
            if (ThreeDigitChunks[0] == 0)
                ThreeDigitChunks.RemoveAt(0);
            else
                result += ConvertLessThanThousand(ThreeDigitChunks[0]);
            return result.Trim();
        }

        //Helper function that takes a number less than 1000 and converts it into words
        private static string ConvertLessThanThousand(int x)
        {
            int numDigits = x.ToString().Length;

            //Convert int to int array
            List<int> xList = new List<int>();
            for (int i = 0; i < numDigits; i++)
            {
                int lastDigit = x % 10;
                xList.Add(lastDigit);
                x /= 10;
            }
            xList.Reverse();

            //Convert array to words
            string result = "";

            //Hundreds place
            if (xList.Count == 3)
            {
                int firstDigit = xList[0];
                IntWord firstWord = (IntWord)firstDigit;
                result += firstWord.ToString() + " Hundred ";
                xList.RemoveAt(0);
            }

            //Handles 100, 200, 300, etc. cases
            if ((xList.Count == 2) && (xList[0] == 0) && (xList[1] == 0))
                return result;

            //Tens place
            if (xList.Count == 2)
            {
                int firstDigit = xList[0];
                if (firstDigit > 1)
                {
                    IntTens firstWord = (IntTens)firstDigit;
                    result += firstWord.ToString();
                    xList.RemoveAt(0);
                }
                else
                {
                    int secondDigit = xList[1];
                    int twoDigits = int.Parse(firstDigit.ToString() + secondDigit.ToString());
                    IntWord lastWord = (IntWord)twoDigits;
                    result += lastWord.ToString();
                    xList.RemoveAt(0);
                    xList.RemoveAt(0);
                }
            }

            //Single Digits
            //Check if it equals 0 or it will print zero after numbers like 890
            if ((xList.Count == 1) && (xList[0] != 0))
            {
                int firstDigit = xList[0];
                IntWord firstWord = (IntWord)firstDigit;
                result += " " + firstWord.ToString();
            }
            return result;
        }

    }
    public enum IntTens
    {
        Twenty = 2,
        Thirty = 3,
        Forty = 4,
        Fifty = 5,
        Sixty = 6,
        Seventy = 7,
        Eighty = 8,
        Ninety = 9
    }

    public enum IntWord
    {
        Zero = 0,
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Eleven = 11,
        Twelve = 12,
        Thirteen = 13,
        Fourteen = 14,
        Fifteen = 15,
        Sixteen = 16,
        Seventeen = 17,
        Eighteen = 18,
        Nineteen = 19,
    }
}