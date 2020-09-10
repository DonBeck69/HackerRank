using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Interview.Strings
{
    public class MakingAnagrams
    {


        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int makeAnagram(string a, string b)
        {
            Dictionary<char, int> lettersA = new Dictionary<char, int>();
            Dictionary<char, int> lettersB = new Dictionary<char, int>();

            int res = 0;
            char[] ac = a.ToCharArray();
            char[] bc = b.ToCharArray();
            List<char> dist = new List<char>();
            dist.AddRange(ac);
            dist.AddRange(bc);
            dist = dist.Distinct().ToList();
            foreach(char leter in dist)
            {
                lettersA.Add(leter, 0);
                lettersB.Add(leter, 0);
            }

            for (int ai = 0; ai <= ac.Length - 1; ai++)
            {
                lettersA[ac[ai]]++;
            }

            for (int bi = 0; bi <= bc.Length - 1; bi++)
            {
                lettersB[bc[bi]]++;
            }

            foreach (char leter in dist)
            {
                res += Math.Abs(lettersA[leter] - lettersB[leter]);
            }

            return res;
        }
    }
}
