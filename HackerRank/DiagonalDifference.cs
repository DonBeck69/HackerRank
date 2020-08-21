using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HackerRank
{
    public class DiagonalDifference
    {

        public int GetDiagonalDifference(List<List<int>> grid)
        {
            int left = 0;
            int right = 0;
            int rindex = grid[0].Count - 1;
            int lindex = 0;
            foreach (List<int> row in grid)
            {
                left += row[lindex];
                right += row[rindex];
                lindex++;
                rindex--;
            }

            return Math.Abs(left - right);
        }
    }
}
