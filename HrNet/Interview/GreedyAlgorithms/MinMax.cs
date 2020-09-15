using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Interview.GreedyAlgorithms
{
    public class MinMax
    {

        public int maxMin(int k, int[] arr)
        {
            int res = 0;
            Array.Sort(arr);
            res = arr[k - 1] - arr[0];
            int len = arr.Length - k;
            for (int i = 1; i <= len; i++)
            {
                int maxI = (i + k) - 1;
                int check = arr[maxI] - arr[i];
                if (check < res)
                {
                    res = check;
                }
            }
            return res;

        }

        public int maxMin1(int k, int[] arr)
        {
            int res = 0;
            Array.Sort(arr);
            int[] subarr = arr.Take(k).ToArray();
            res = subarr[k - 1] - subarr[0];
            int len = arr.Length - k;
            for (int i = 1; i <= len; i++)
            {
                subarr = arr.Skip(i).Take(k).ToArray();
                int check = subarr[k - 1] - subarr[0];
                if (check < res)
                {
                    res = check;
                }
            }
            return res;

        }


        public int maxMin2(int k, int[] arr)
        {
            int res = 0;
            Array.Sort(arr);
            int[] subarr = arr.Take(k).ToArray();
            res = subarr.Max() - subarr.Min();
            int len = arr.Length - k; 
            for(int i = 1; i <= len; i++)
            {
                subarr = arr.Skip(i).Take(k).ToArray();
                int check = subarr.Max() - subarr.Min();
                if (check < res)
                {
                    res = check;
                }
            }
            return res;

        }
    }
}
