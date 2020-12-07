using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet
{
    public class ElectronicsShop
    {
        public int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int res = -1;
            Array.Sort(keyboards);
            Array.Sort(drives);
            for (int k = 0; k < keyboards.Length; k++)
            {
                for (int d = 0; d < drives.Length; d++)
                {
                    if (keyboards[k] + drives[d] > b)
                    {
                        break;
                    }
                    if (keyboards[k] + drives[d] > res)
                    {
                        res = keyboards[k] + drives[d];
                    }
                }
            }

            return res;
        }
    }
}
