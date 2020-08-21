using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class BirthdayChocolate
    {
        public int birthday(List<int> s, int d, int m)
        {
            int result = 0;
            for (int index = 0; index <= s.Count - 1; index++)
            {
                List<int> sub = s.Skip(index).Take(m).ToList();
                if (sub.Sum() == d)
                {
                    result++;
                }
            }

            return result;
        }

    }
}
