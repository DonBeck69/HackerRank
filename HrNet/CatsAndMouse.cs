using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet
{
    public class CatsAndMouse
    {
        public string catAndMouse(int x, int y, int z)
        {
            string res = string.Empty;
            decimal a = Math.Abs(x - z);
            decimal b = Math.Abs(y - z);
            if (a == b)
            {
                res = "Mouse C";
            }
            else if (a > b)
            {
                res = "Cat B";
            } else
            {
                res = "Cat A";
            }

            return res;

        }
    }
}
