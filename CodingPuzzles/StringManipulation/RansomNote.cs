using System.Collections.Generic;

namespace CodingPuzzles
{
    //A ransom note can be formed by cutting characters out of a magazine to form a new sentence.
    //How would you figure out if a ransom note (represented as a string) can be formed
    //from a given magazine (string)?
    public static class RansomNote
    {
        //Character version
        public static bool RansomNoteCanBeFormedChars(string note, string mag)
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

        //Word version
        public static bool RansomNoteCanBeFormedWords(string note, string mag)
        {
            Dictionary<string, int> d = new Dictionary<string, int>();

            //It's necessary to trim beginning of strings or note.Split will return spaces
            mag = mag.Trim();
            note = note.Trim();

            //Make sure each word is separated by only a single space
            while (mag.Contains("  "))
                mag = mag.Replace("  ", " ");
            while (note.Contains("  "))
                note = note.Replace("  ", " ");

            //Populate dictionary with words in note and their frequency
            foreach (string s in note.Split(' '))
            {
                if (d.ContainsKey(s))
                    d[s]++;
                else
                    d.Add(s, 1);
            }
            //match note words to magazine words
            foreach (string s in mag.Split(' '))
            {
                if (d.ContainsKey(s))
                    d[s]--;
            }
            //check if any words in the note were not found in the magazine
            foreach (KeyValuePair<string, int> entry in d)
            {
                if (entry.Value > 0)
                    return false;
            }
            return true;
        }

        ////Call in Program.cs to test
        ////Output should be true
        //bool a = RansomNote.RansomNoteCanBeFormedWords("  they   to  ", "        two    systems are talking to each other, they always need to specify what encoding      ");
        //Console.WriteLine(a);
    }
}