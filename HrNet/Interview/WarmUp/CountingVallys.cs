using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Interview.WarmUp
{
    public class CountingVallys
    {
        public int countingValleys(int steps, string path)
        {
            int res = 0;
            char[] cpath = path.ToCharArray();
            int alt = 0;
            for(int i = 0; i <= cpath.Length - 1; i++)
            {
                if (cpath[i] == 'U')
                {
                    alt++;
                    if (alt == 0)
                    {
                        res++;
                    }
                }
                else
                {
                    alt--;
                }
            }

            return res;
        }
    }
}
