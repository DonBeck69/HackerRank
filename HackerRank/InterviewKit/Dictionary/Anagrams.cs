using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.InterviewKit.Dictionary
{
    public class Anagrams
    {
        public int sherlockAndAnagrams(string s)
        {
            int result = 0;
            char[] words = s.ToCharArray();
            //to store alphabetized "words" and the count
            Dictionary<string, int> wordsList = new Dictionary<string, int>();
            //grow word count from 1 lenght - 1
            for (int wordCount = 1; wordCount <= s.Length - 1; wordCount++)
            {
                // loop string to extract words of wordlength, alphabetize word
                for(int index = 0; index <= s.Length - wordCount; index++)
                {
                    string word = new string(words, index, wordCount);
                    string aword = Alphabetize(word);
                    if (wordsList.ContainsKey(aword))
                    {
                        wordsList[aword]++;

                    }
                    else
                    {
                        wordsList.Add(aword, 1);
                    }
                }
            }

            // count anangrams and add scores
            foreach(KeyValuePair<string, int> word in wordsList)
            {
                int val = word.Value;
                if(val > 1)
                {
                    result += (val - 1) * val / 2; // it's a formula, who'dv thunk
                }
            }

            return result;

        }

        public string Alphabetize(string word)
        {
            char[] ca = word.ToCharArray();
            Array.Sort(ca);
            return new string(ca);
        }
    }
}
