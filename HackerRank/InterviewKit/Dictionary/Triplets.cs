using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace HackerRank.InterviewKit.Dictionary
{
    public class Triplets
    {


        public long countTriplets(List<long> arr, long r)
        {
            long result = 0;
            // one dictionary to hold and track data for single pass

            // distinct numbers from array, with number count
            Dictionary<long, long> L1 = new Dictionary<long, long>(); 

            // 2 tuple number found and count
            Dictionary<long, long> L2 = new Dictionary<long, long>(); 

            //3 tuple number & count and 
            Dictionary<long, long> L3 = new Dictionary<long, long>();
            for (int x = 0; x <= arr.Count - 1; x++)
            {
                long number = arr[x];

                //Update in this order L1, L2, L3 (eg. L3 must be ckecked against L2 before L2 is updated)
                if (number % r == 0) // only take numbers divisible by "r"
                {
                    //L3
                    if (L2.ContainsKey(number / r))
                    {
                        if (L3.ContainsKey(number))
                        {
                            L3[number] = L2[number / r] + L3[number];

                        }
                        else
                        {
                            L3.Add(number, L2[number / r]);
                        }
                    }

                    //L2
                    if (L1.ContainsKey(number / r))
                    {
                        if (L2.ContainsKey(number))
                        {
                            L2[number] = L1[number / r] + L2[number];

                        }
                        else
                        {
                            L2.Add(number, L1[number / r]);
                            //L1[number / r]++;
                        }
                    }
                }

                //L1 (take all numbers eg. 1 is not % 2 but must be in the list)
                if (L1.ContainsKey(number))
                {
                    L1[number]++;
                }
                else
                {
                    L1.Add(number, 1);
                }

            }

            result = L3.Sum(l => l.Value);
            return result;

        }


        public long countTriplets2(List<long> arr, long r)
        {
            long result = 0;
            Dictionary<long, long> L1 = new Dictionary<long, long>();
            Dictionary<long, long> L2 = new Dictionary<long, long>();
            Dictionary<long, long> L3 = new Dictionary<long, long>();
            for (int x = 0; x <= arr.Count - 1; x++)
            {
                long number = arr[x];
                if (L1.ContainsKey(number))
                {
                    L1[number]++;
                }
                else
                {
                    L1.Add(number, 1);
                }

                if (number % r == 0)
                {
                    if (x > 0)
                    {
                        if (L1.ContainsKey(number / r))
                        {
                            if (L2.ContainsKey(number))
                            {
                                L2[number] = L1[number / r] + L2[number];

                            }
                            else
                            {
                                L2.Add(number, L1[number / r]);
                                //L1[number / r]++;
                            }
                        }
                    }
                    if (x > 1)
                    {
                        if (L2.ContainsKey(number / r))
                        {
                            if (L3.ContainsKey(number))
                            {
                                L3[number] = L2[number / r] + L3[number];

                            }
                            else
                            {
                                L3.Add(number, L2[number / r]);
                            }
                        }
                    }

                }
            }

            result = L3.Sum(l => l.Value);
            return result;

        }


    }
}
