using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet
{
    public class DrawingBook
    {

        /// <summary>
        /// determine the pages needed to be turned to reach page p of n
        /// It's a math problem
        /// if page, p, is more than half, calulate from end
        /// else calulate from begining.
        /// use and abuse Int32 division
        /// </summary>
        /// <param name="n"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public int pageCount(int n, int p)
        {
            int res = 0;
            if(p <= n/2)
            {
                res = p / 2;
            }
            else
            {
                res = (n / 2) - (p / 2);
            }

            return res;

        }
    }
}
