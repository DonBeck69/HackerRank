using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class VowelCounter
    {
        private char[] vowles = new char[] { 'a', 'e', 'i', 'o', 'u' };

        public string findSubstring(string s, int k)
        {
            string result = string.Empty;

            bool[] vowels = ConverStringToBool(s.ToCharArray());
            int highest = 0;
            for (int index = 0; index <= vowels.Length - k; index++)
            {
                //count the "trues"
                int count = 0;
                for (int bindex = index; bindex < index + k; bindex++)
                {
                    if (vowels[bindex])
                    {
                        count++;
                    }
                }

                if (count > highest)
                {
                    highest = count;
                    result = s.Substring(index, k);
                }
            }

            return result;
        }



        public bool[] ConverStringToBool(char[] values)
        {
            bool[] result = new bool[values.Length];
            int index = 0;
            foreach (char c in values)
            {
                bool isVowel = CheckIfCharacterIsVowl(c);
                result[index++] = isVowel;
            }

            return result;
        }

        public bool CheckIfCharacterIsVowl(char test)
        {
            bool result = false;
            foreach (char c in vowles)
            {
                if (test == c)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

    }
}
