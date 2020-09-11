using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Interview.Strings
{
    public class SherlockValidString
    {
        public string isValid(string s)
        {
            string res = "NO";
            char[] letters = s.ToCharArray();
            Dictionary<char, int> letterMap = new Dictionary<char, int>();
            List<char> charList = letters.ToList();
            charList = charList.Distinct().ToList();
            foreach(char letter in charList)
            {
                letterMap.Add(letter, 0);
            }
            for (int i = 0; i <= letters.Length - 1; i++)
            {
                letterMap[letters[i]]++;
            }


            //Now... What to do with this data...???
            Dictionary<int, int> freekMap = new Dictionary<int, int>();
            foreach(KeyValuePair<char, int> pair in letterMap)
            {
                if(freekMap.ContainsKey(pair.Value))
                {
                    freekMap[pair.Value]++;
                }
                else
                {
                    freekMap.Add(pair.Value, 1);
                }
            }

            if (freekMap.Count == 1)
            {
                res = "YES";
            }
            else if (freekMap.Count == 2)
            {
                int freek0 = freekMap.ElementAt(0).Value;
                int freek1 = freekMap.ElementAt(1).Value;
                if (freek0 == 1 || freek1 == 1)
                {
                    if(Math.Abs(freekMap.ElementAt(0).Key - freekMap.ElementAt(1).Key) == 1)
                    {
                        res = "YES";
                    }
                }
            }

            return res;

        }
    }
}
