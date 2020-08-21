using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class DivisibleSumPairs
    {

        public int divisibleSumPairs(int n, int k, int[] ar)
        {
            int result = 0;
            for (int sIndex = 0; sIndex <= ar.Length - 1; sIndex++)
            {
                int summer = ar[sIndex];
                for (int index = sIndex + 1; index <= ar.Length -1; index++)
                {
                    if ((ar[sIndex] + ar[index]) % k == 0)
                    {
                        result++;
                    }
                }
            }

            return result;

        }
    }
}
