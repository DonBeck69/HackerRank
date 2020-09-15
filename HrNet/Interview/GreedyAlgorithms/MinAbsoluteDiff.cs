using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNeT.Interview.GreedyAlgorithms
{

    /// <summary>
    /// sort the array, itterate and find lowest diff.
    /// </summary>
    public class MinAbsoluteDiff
    {
        public int minimumAbsoluteDifference(int[] arr)
        {
            Array.Sort(arr);
            int res = arr.Last();
            for (int i = 0; i <= arr.Length - 2; i++)
            {
                if (Math.Abs(arr[i] - arr[i + 1]) <= res)
                {
                    res = Math.Abs(arr[i] - arr[i + 1]);
                }
            }

            return res;

        }
    }
}
