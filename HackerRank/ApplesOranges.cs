using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class ApplesOranges
    {

        public void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            // s & t = house
            //a = apple tree
            //b = orange tree
            int countA = 0;
            int countO = 0;
            for (int index = 0; index <= apples.Length - 1; index++)
            {
                if (apples[index] >= s - a && apples[index] <= t - a)
                {
                    countA++;
                }
            }

            for (int index = 0; index <= oranges.Length - 1; index++)
            {
                if (oranges[index] <= t - b && oranges[index] >= s - b)
                {
                    countO++;
                }
            }

            Console.WriteLine(countA);
            Console.WriteLine(countO);

        }
    }
}
