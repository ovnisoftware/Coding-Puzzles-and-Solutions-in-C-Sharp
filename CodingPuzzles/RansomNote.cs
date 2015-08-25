using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //A ransom note can be formed by cutting characters out of a magazine to form a new sentence.
    //How would you figure out if a ransom note (represented as a string) can be formed
    //from a given magazine (string)?
    public static class RansomNote
    {
        public static bool WillFit(string note, string mag)
        {
            Dictionary<char, int> noteChars = new Dictionary<char, int>();

            //Remove whitespace from both strings
            note = note.Replace(" ", "");
            mag = mag.Replace(" ", "");

            //Store the number of occurrences of each character in the note in a dictionary
            foreach (char c in note)
            {
                if (noteChars.ContainsKey(c))
                    noteChars[c]++;
                else
                    noteChars.Add(c, 1);
            }

            //Iterate through each character in the magazine and decrement the corresponding 
            //character in the note's dictionary
            foreach (char c in mag)
            {
                if (noteChars.ContainsKey(c))
                    noteChars[c]--;
            }

            //Confirm there are no characters in the note that were not found in the magazine
            foreach (KeyValuePair<char, int> entry in noteChars)
            {
                if (entry.Value > 0)
                    return false;
            }
            return true;
        }
            ////Call this in Program.cs to test
            ////Output should be true
            //string note = "aabb";
            //string mag = "aaabb";
            //Console.WriteLine(RansomNote.WillFit(note, mag));
    }
}