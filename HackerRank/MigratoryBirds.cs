using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class MigratoryBirds
    {
        public int migratoryBirds(List<int> arr)
        {
            int result = 0;

            // get a distinct bird list
            List<int> birds = arr.Distinct().ToList();
            // create a dictionary to keep bird type (key) and the number of sightings
            Dictionary<int, int> birdScores = new Dictionary<int, int>();
            foreach(int bird in birds)
            {
                birdScores.Add(bird, 0);
            }

            //add each sighing to the bird type
            foreach(int sighting in arr)
            {
                birdScores[sighting]++;
            }

            //sort by value (desc) and key (acen), take first.
            IOrderedEnumerable<KeyValuePair<int, int>> sortedScores = birdScores.OrderByDescending(v => v.Value).ThenBy(k => k.Key);
            result = sortedScores.First().Key;
            return result;

        }
    }
}
