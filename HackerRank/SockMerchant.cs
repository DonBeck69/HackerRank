using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class SockMerchant
    {
        public int sockMerchant(int n, int[] ar)
        {
            int result = 0;

            // get a distinct socks list
            List<int> socks = ar.Distinct().ToList();
            // create a dictionary to keep bird type (key) and the number of sightings
            Dictionary<int, int> sockScores = new Dictionary<int, int>();
            foreach (int bird in socks)
            {
                sockScores.Add(bird, 0);
            }

            //add each sighing to the bird type
            foreach (int color in ar)
            {
                sockScores[color]++;
            }

            foreach(KeyValuePair<int, int> sockColor in sockScores)
            {
                int sockPairCount = sockColor.Value / 2;
                if (sockPairCount >= 1)
                {
                    result += sockPairCount;
                }
            }
            return result;

        }
    }
}
