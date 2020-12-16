using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/utopian-tree/problem
    /// </summary>
    public class UtopianTree
    {
        public int utopianTree(int n)
        {
            int res = 1;
            bool spring = true;
            for (int i = 1; i <= n; i++)
            {
                if (spring)
                {
                    res = res + res;
                }
                else
                {
                    res++;
                }

                spring = !spring;
            }

            return res;

        }
    }
}
