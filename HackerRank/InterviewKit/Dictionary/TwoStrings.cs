using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.InterviewKit.Dictionary
{
    public class TwoStrings
    {
        public string twoStrings(string s1, string s2)
        {
            string result = "NO";


            List<string> word1 = new List<string>();
            List<string> word2 = new List<string>();
            if (s1.Length > s2.Length)
            {
                word1.AddRange(s1.Select(c => c.ToString()));
                word2.AddRange(s2.Select(c => c.ToString()));
            }
            else 
            {
                word1.AddRange(s2.Select(c => c.ToString()));
                word2.AddRange(s1.Select(c => c.ToString()));
            }

            word1 = word1.Distinct().ToList();
            word1.Sort();
            word2 = word2.Distinct().ToList();
            word2.Sort();
            foreach(string w in word2)
            {
                if (word1.Contains(w))
                {
                    result = "YES";
                    break;
                }
            }



            return result;

        }
    }
}
