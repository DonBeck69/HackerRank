using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class BreakingRecords
    {
        public int[] breakingRecords(int[] scores)
        {
            int min = scores[0];
            int minCount = 0;
            int max = scores[0];
            int maxCount = 0;
            for(int index = 1; index <= scores.Length - 1; index++)
            {
                if (max < scores[index])
                {
                    max = scores[index];
                    maxCount++;
                }
                if (min > scores[index])
                {
                    min = scores[index];
                    minCount++;
                }
            }

            return new int[] { maxCount, minCount };
        }
    }
}
