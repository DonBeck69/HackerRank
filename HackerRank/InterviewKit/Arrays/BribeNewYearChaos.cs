using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class BribeNewYearChaos
    {
        public string minimumBribes(int[] q)
        {
            string result = string.Empty;

            int bribes = 0;
            int sortingErrors = 1;

            // check for "Too Chaotic" 1st
            for (int index = 0; index <= q.Length - 1; index++)
            {
                if (q[index] >= (index + 1))
                {
                    if (q[index] - (index + 1) > 2)
                    {
                        sortingErrors = 0;
                        bribes = -1;
                        result = "Too chaotic";
                        break;
                    }

                }
            }

            int bribe = 0;

            while (sortingErrors > 0)
            {
                sortingErrors = 0;
                for (int index = 0; index <= q.Length - 2; index++)
                {
                    int val = q[index];
                    if (val > q[index + 1])
                    {
                        bribe++;
                        sortingErrors++;
                        q[index] = q[index + 1];
                        q[index + 1] = val;
                    }
                }
            }

            if(bribes >= 0)
            {
                result = bribe.ToString();
            }

            return result;
        }

    }
}
