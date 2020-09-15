using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Interview.Search
{
    public class IceCream
    {

        public string whatFlavors(int[] cost, int money)
        {
            string res = string.Empty;
            Dictionary<int, int> checkVals = new Dictionary<int, int>();
            int one = 0;
            int two = 0;
            int keyIndex = 0;
            for (int index = 0; index <= cost.Length - 1; index++)
            {
                int val = money - cost[index];
                if (checkVals.TryGetValue(val, out keyIndex))
                {
                    one = keyIndex;
                    two = index;
                    break;
                }

                if (checkVals.TryGetValue(cost[index], out keyIndex) == false)
                {
                    checkVals.Add(cost[index], index);
                }
            }

            if (one > two)
            {
                int temp = two;
                two = one;
                one = temp;
            }

            res = $"{one + 1} {two + 1}";
            return res;
        }

    }
}
