using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Interview.Strings
{
    /// <summary>
    /// Longest common subsequence problem
    /// https://en.wikipedia.org/wiki/Longest_common_subsequence_problem
    /// </summary>
    public class CommonChild
    {
        public int commonChild(string s1, string s2)
        {
            int res = 0;
            char[] sa1 = s1.ToCharArray();
            char[] sa2 = s2.ToCharArray();
            int[,] matrix = new int[sa1.Length + 1, sa2.Length + 1];

            for(int i1 = 1; i1 <= sa1.Length; i1++)
            {
                for (int i2 = 1; i2 <= sa2.Length; i2++)
                {
                    if (sa1[i1 - 1] == sa2[i2 - 1])
                    {
                        matrix[i1, i2] = matrix[i1 - 1, i2 - 1] + 1;
                    }
                    else
                    {
                        matrix[i1, i2] = Math.Max(matrix[i1 - 1, i2], matrix[i1, i2 - 1]);//the highest val behind, or above
                    }
                }
            }

            res = matrix[sa1.Length, sa2.Length];
            return res;

        }
    }
}
