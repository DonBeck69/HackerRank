using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;

namespace HackerRank
{
    public class MinimumSwaps
    {
        public int minimumSwaps(int[] arr)
        {
            int result = 0;
            Dictionary<int, int> arrpos = new Dictionary<int, int>();
            for (int index = 0; index <= arr.Length - 1; index++)
            {
                arrpos.Add(arr[index], index);
            }

            int[] sorted = arrpos.OrderBy(x => x.Key).ToDictionary(k => k.Key, v => v.Value).Values.ToArray();
            bool[] visited = new bool[arr.Length];
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if (visited[i] || sorted[i] == i)

                {
                    continue;
                }
                else
                {
                    int cycle = 0;

                    int p = i;
                    while (!visited[p])
                    {
                        visited[p] = true;
                        p = sorted[p];
                        cycle++;
                    }

                    if (cycle > 0)
                    {
                        result += (cycle - 1);
                    }
                }
            }
            return result;
        }





    }
}
