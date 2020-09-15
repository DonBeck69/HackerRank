using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNeT.Interview.GreedyAlgorithms
{
    public class GreedyFlorist
    {
        public int getMinimumCost(int k, int[] c)
        {
            //sneaky, sneaky... 
            int res = 0;
            Array.Sort(c);
            int i = c.Length - 1;
            int purchaesd = 0;
            while(i >=0)
            {
                for (int cust = 1; cust <= k && i >= 0; cust++)
                {
                    res += c[i] * (purchaesd + 1);
                    i--;
                }

                purchaesd++;
            }
            return res;
        }
    }
}
