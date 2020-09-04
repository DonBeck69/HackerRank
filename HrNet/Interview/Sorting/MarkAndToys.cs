using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Interview.Sorting
{
    public class MarkAndToys
    {
        public int maximumToys(int[] prices, int k)
        {
            int res = 0;
            Array.Sort(prices);
            int total = 0;
            for(int index = 0; index <= prices.Length - 1; index++)
            {
                if (total + prices[index] >= k)
                {
                    break;
                }
                else
                {
                    res++;
                    total += prices[index];
                }
            }

            return res;

        }
    }
}
