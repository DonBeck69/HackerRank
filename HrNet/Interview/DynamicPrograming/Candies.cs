using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Interview.DynamicPrograming
{
    public class Candies
    {
        public long candies(int n, int[] arr)
        {
            int[] dec = new int[arr.Length];
            long[] ace = new long[arr.Length];
            //dec[0] = 1;
            //ace[0] = 1;
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                int dv = 1;
                if (i < arr.Length - 1)
                {
                    if (arr[i] >= arr[i + 1])
                    {
                        if (i > 0 && dec[i - 1] > 1)
                        {
                            dv = dec[i - 1] - 1;
                        }
                        else
                        {
                            dv = CountDec(arr, i + 1);
                        }
                    }
                }

                dec[i] = dv;
                long av = dv;
                if (i > 0)
                {
                    if (arr[i - 1] < arr[i])
                    {
                        av = Math.Max(ace[i - 1] + 1, dec[i]);
                    }
                }
                ace[i] = av;
                Console.WriteLine(ace.Sum());
            }

            return ace.Sum();
        }

        public int CountDec(int[] arr, int index)
        {
            int res = 1;
            while (index <= arr.Length -1 && arr[index - 1] > arr[index])
            {
                res++;
                index++;
            }
            return res;
        }

    }
}
