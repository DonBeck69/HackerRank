using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class Kangaroo
    {
        public string kangaroo(int x1, int v1, int x2, int v2)
        {
            string result = "NO";
            if (v1 != v2)
            {
                int diff = x1 - x2; //constraints indicate x1 < x2...
                while (diff < 0)
                {
                    x1 += v1;
                    x2 += v2;
                    if (x1 - x2 < diff)
                    {
                        break;
                    }
                    diff = x1 - x2;
                }

                if (diff == 0)
                {
                    result = "YES";
                }
            }
            return result;
        }
    }
}
