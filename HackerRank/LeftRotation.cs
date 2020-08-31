using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class LeftRotation
    {
        public int[] rotLeft(int[] a, int d)
        {
            int[] result = new int[a.Length];

            for (int index = 0; index <= a.Length - 1; index++)
            {
                result[index] = a[d];
                d++;
                if(d >= a.Length)
                {
                    d = 0; 
                }
            }

            return result;

        }

    }
}
