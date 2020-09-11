using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Interview.Strings
{
    public class AlternatingChar
    {
        public int alternatingCharacters(string s)
        {
            int res = 0;
            char[] letters = s.ToCharArray();
            char lastLetter = letters[0];
            for (int i = 1; i <= letters.Length - 1; i++)
            {
                if (lastLetter != letters[i])
                {
                    lastLetter = letters[i];
                    
                }
                else
                {
                    res++;
                }
            }

            return res;

        }
    }
}
