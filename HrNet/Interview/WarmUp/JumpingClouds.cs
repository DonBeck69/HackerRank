using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Interview.WarmUp
{
    public class JumpingClouds
    {
        public  int jumpingOnClouds(int[] c)
        {
            int res = 0;
            int i = 0;
            while (i <= c.Length - 2)
            {
                if (i >= c.Length - 2 || c[i + 2] == 1)
                {
                    i++;
                }
                else
                {
                    i += 2;
                }

                res++;
            }
            return res;
        }
    }
}
