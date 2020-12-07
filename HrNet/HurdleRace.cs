using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet
{
    public class HurdleRace
    {
        public int hurdleRace(int k, int[] height)
        {
            int res = height.Max() - k;
            if (res < 0)
            {
                res = 0;
            }

            return res;

        }
    }
}
