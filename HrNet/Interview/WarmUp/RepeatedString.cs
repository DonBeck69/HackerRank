using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Interview.WarmUp
{
    public class RepeatedString
    {
        public long repeatedString(string s, long n)
        {
            long res = 0;
            int len = s.Length;
            long remain = n % Convert.ToInt64(s.Length);
            long repeat = Convert.ToInt64(Math.Floor(Convert.ToDecimal(n) / Convert.ToDecimal(s.Length)));
            char[] sc = s.ToCharArray();
            int tot = 0;
            int remainCount = 0;
            //int start = 0;
            int index = s.IndexOf("a");
            while (index > -1)
            {
                if (remain > 0 && index < remain)
                {
                    remainCount++;
                }
                tot++;
                index = s.IndexOf("a", index + 1);
            }

            res = (tot * repeat) + remainCount;


            return res;
        }

    }
}
