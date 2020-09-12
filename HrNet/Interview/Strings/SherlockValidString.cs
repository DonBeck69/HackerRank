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
            // create a map of letters and the counts thereoff
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
            //create a frequency map
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

            //now for the logic... if else, if else, ifff, ifff iffy... Urgh!
            if (freekMap.Count == 1)
            {
                res = "YES";
            }
            else if (freekMap.Count == 2)
            {
                // order frequency map low to high
                freekMap = freekMap.OrderBy(k => k.Key).ToDictionary(k => k.Key, v => v.Value);
                int freek0 = freekMap.ElementAt(0).Value;
                int freek1 = freekMap.ElementAt(1).Value;
                if (freek0 == 1 || freek1 == 1)
                {
                    //check for both even or odd if 1st element > 1
                    // if 1st even, 2nd should be odd and visa-versa... 
                    if (freekMap.ElementAt(0).Key > 1)
                    {
                        if (freekMap.ElementAt(1).Key % freekMap.ElementAt(0).Key > 0)
                        {
                            res = "YES";
                        }
                    }
                    else if(freekMap.ElementAt(0).Value == 1)
                    {
                        res = "YES";
                    }
                }
            }

            return res;

        }
    }
}
