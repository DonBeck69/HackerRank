using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.InterviewKit.Dictionary
{
    public class RansomNote
    {
        public string checkMagazine(string[] magazine, string[] note)
        {
            string result = "Yes";

            Dictionary<string, int> mags = BuildDictionary(magazine);
            Dictionary<string, int> notes = BuildDictionary(note);

            foreach(KeyValuePair<string, int> word in notes)
            {
                if ((mags.ContainsKey(word.Key) && mags[word.Key] >= word.Value) == false)
                {
                    result = "No";
                    break;
                }
            }

            return result;
        }

        private Dictionary<string, int> BuildDictionary(string[] arr)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            for(int index = 0; index <= arr.Length - 1; index++)
            {
                if(result.ContainsKey(arr[index]))
                {
                    result[arr[index]]++;
                }
                else
                {
                    result.Add(arr[index], 1);
                }
            }

            return result;
        }


        public string checkMagazineBrute(string[] magazine, string[] note)
        {
            string result = "Yes";
            List<string> magazines = new List<string>(magazine);
            List<string> notes = new List<string>(note);
            foreach (string n in notes)
            {
                if (magazines.Contains(n))
                {
                    magazines.Remove(n);
                }
                else
                {
                    result = "No";
                    break;
                }
            }

            return result;
        }

    }
}
