using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNeT.Interview.GreedyAlgorithms
{
    public class LuckBalance
    {
        public int luckBalance(int k, int[][] contests)
        {
            int res = 0;
            //int[] scores = contests[0];
            Dictionary<int, int> map = new Dictionary<int, int>();
            for(int i = 0; i <= contests.Length - 1; i++)
            {
                map.Add(i, contests[i][0]);
            }

            map = map.OrderByDescending(v => v.Value).ToDictionary(y => y.Key, v => v.Value);

            foreach(KeyValuePair<int, int> score in map)
            {
                if (contests[score.Key][1] == 0)
                {
                    res += score.Value;
                }
                else
                {
                    if(k > 0)
                    {
                        res += score.Value;
                        k--;
                    }
                    else
                    {
                        res -= score.Value;
                    }
                }
            }

            return res;
        }
    }
}
