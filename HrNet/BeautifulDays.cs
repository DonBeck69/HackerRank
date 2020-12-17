using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/beautiful-days-at-the-movies/problem
    /// </summary>
    public class BeautifulDays
    {
        public  int beautifulDays(int i, int j, int k)
        {
            int res = 0;
            for (int n = i; n <= j; n++)
            {
                //reverse the number
                int reverse = ReverseInt(n);
                // get absolute diff
                int diff = Math.Abs(n - reverse);
                //test if clean divide by k
                if (diff % k == 0)
                {
                    res++;
                }
            }
            return res;
        }

        public int ReverseInt(int number)
        {
            int reverse = 0;
            int temp = number;
            while(Convert.ToBoolean(temp))
            {
                int remainder = temp % 10;
                reverse = reverse * 10 + remainder;
                temp = temp / 10;
            }

            return reverse;
        }
    }
}
