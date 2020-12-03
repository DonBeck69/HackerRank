using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Interview.Search
{

    public class Pairs
    {
        /// <summary>
        /// Sort and use 2 pointer alg
        /// </summary>
        /// <param name="k"></param>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int pairs(int k, int[] arr)
        {
            int res = 0;
            Array.Sort(arr);
            int i = 0;
            int j = 0;
            int diff = 0;
            while (i < arr.Length && j < arr.Length )
            {
                diff = arr[j] - arr[i];
                if (diff == k)
                {
                    res++;
                    i++;
                    j++;
                }
                else if(diff < k)
                {
                    j++;
                }
                else
                {
                    i++;
                }
            }
            return res;
        }

    }
}
