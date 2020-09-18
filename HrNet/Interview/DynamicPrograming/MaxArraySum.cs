using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Interview.DynamicPrograming
{
    /// <summary>
    /// 
    /// </summary>
    public class MaxArraySum
    {

        /// <summary>
        /// Kadane's Algorithm
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int maxSubsetSum(int[] arr)
        {
            int tmp = 0;
            int inc = 0;
            int exc = 0;
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                tmp = inc;
                inc = Math.Max(arr[i] + exc, tmp);
                exc = tmp;
            }
            return Math.Max(inc, exc);

        }



    }
}
