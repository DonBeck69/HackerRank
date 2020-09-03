using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.InterviewKit.Dictionary
{
    public class Frequency
    {

        public List<int> freqQuery(List<int[]> queries, List<int> OutVals = null)
        {
            List<int> res = new List<int>();
            Dictionary<int, int> data = new Dictionary<int, int>();
            Dictionary<int, int> free = new Dictionary<int, int>();

            int outIndex = 0;

            for (int index = 0; index <= queries.Count() - 1; index++)// List<int> query in queries)
            {
                int action = queries[index][0];
                int value = queries[index][1];
                int outVal;

                if (action == 1)
                {


                    if (data.TryGetValue(value, out outVal))
                    {
                        if (free.TryGetValue(data[value], out outVal))
                        {
                            if (free[data[value]] > 0)
                            {
                                free[data[value]]--;
                            }
                        }

                        data[value]++;
                    }
                    else
                    {
                        data.Add(value, 1);
                    }

                    if (free.TryGetValue(data[value], out outVal))
                    {
                        free[data[value]]++;
                    }
                    else
                    {
                        free.Add(data[value], 1);
                    }
                }
                if (action == 2)
                {
                    if (data.TryGetValue(value, out outVal))
                    {
                        if (free.TryGetValue(data[value], out outVal))
                        {
                            if (free[data[value]] > 0)
                            {
                                free[data[value]]--;
                            }
                        }

                        if (data[value] > 0)
                        {
                            data[value]--;
                        }

                        if (free.TryGetValue(data[value], out outVal))
                        {
                            free[data[value]]++;
                        }
                    }


                }
                if (action == 3)
                {
                    int freek = value;
                    int f = 0;
                    if (free.TryGetValue(freek, out outVal))
                    {
                        if (outVal > 0)
                        {
                            f = 1;
                        }
                    }
                    res.Add(f);
                    if (OutVals != null)
                    {
                        if (f != OutVals[outIndex])
                        {
                            Console.WriteLine(index);
                        }
                    }

                    outIndex++;

                }
            }

            return res;

        }


    }
}

