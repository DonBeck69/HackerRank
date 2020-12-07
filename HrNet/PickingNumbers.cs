using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/picking-numbers/problem
    /// sort the array and then look for sub arrays
    /// </summary>
    public class PickingNumbers
    {

        public int pickingNumbers(List<int> a)
        {
            
            a.Sort();
            int lastVal = a[0]; // previous itteration value
            int totalLen = 1; //track longest sub array
            int tempLen = 1; // track len of current array
            for(int i = 1; i < a.Count(); i++)
            {
                if (a[i] - lastVal <= 1)
                {
                    tempLen++;
                    if (tempLen > totalLen)
                    {
                        totalLen = tempLen;
                    }
                }
                else
                {
                    tempLen = 1;
                    lastVal = a[i];
                }

            }
            return totalLen;
        }


        public int pickingNumbers2(List<int> a)
        {
            int len = 0;
            int begining = 0;
            int start = 0;
            //int end = 0;
            Dictionary<int, int> window = new Dictionary<int, int>();
            for (int end = 0; end < a.Count(); end++)
            {
                if (window.ContainsKey(a[end]))
                {
                    window[a[end]]++;
                }
                else
                {
                    window.Add(a[end], 0);
                }

                int min = window.First().Key;
                int max = window.Last().Key;
                if (max - min <= 1)
                {
                    if (len < end - start + 1)
                    {
                        len = end - start + 1;
                        begining = start;
                    }
                }
                else
                {
                    while (start < end)
                    {
                        window[a[start]]--;
                        if (window[a[start]] == 0)
                        {
                            window.Remove(a[start]);
                        }

                        start++;
                        min = window.First().Key;
                        max = window.Last().Key;
                        if (max - min <= 1)
                        {
                            break;
                        }
                    }
                }
            }

            return 0;
        }

    }
}
