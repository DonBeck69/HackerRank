using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Interview.Arrays
{
    public class ArrayManipulation
    {

        public long arrayManipulation(int n, int[][] queries)
        {
            long max = 0;
            long[] resA = new long[n + 2];  // the negative is added b+1...
            long holder = 0;
            for (int index = 0; index <= queries.Length - 1; index++)
            {
                resA[queries[index][0]] += queries[index][2];
                resA[queries[index][1] + 1] += -queries[index][2];
            }

            for (int i = 0; i <= n; i++)
            {
                holder = resA[i] += holder;
                if (holder > max)
                {
                    max = holder;
                }
            }

            return max;
        }

    }
}
