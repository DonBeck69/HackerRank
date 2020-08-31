using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class HourglassArray
    {
        public int hourglassSum(int[][] arr)
        {
            //int result = 0;
            List<int> scores = new List<int>();

            for (int hindex = 0; hindex <= arr.Length - 3; hindex++)
            {
                int[] row = arr[hindex];
                for (int vindex = 0; vindex <= row.Length - 3; vindex++)
                {
                    int score = arr[hindex][vindex] + arr[hindex][vindex + 1] + arr[hindex][vindex + 2];
                    score += arr[hindex + 1][vindex + 1];
                    score += arr[hindex + 2][vindex] + arr[hindex + 2][vindex + 1] + arr[hindex + 2][vindex + 2];
                    scores.Add(score);
                }
            }


            return scores.Max();
        }
    }
}
