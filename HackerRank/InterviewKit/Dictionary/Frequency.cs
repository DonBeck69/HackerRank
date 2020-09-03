using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.InterviewKit.Dictionary
{
    public class Frequency
    {
        public List<int> freqQuery(List<int[]> queries)
        {
            List<int> res = new List<int>();
            Dictionary<int, int> data = new Dictionary<int, int>();



            for(int index = 0; index <= queries.Count - 1; index++)// List<int> query in queries)
            {
                int action = queries[index][0];
                int value = queries[index][1];
                int outVal;
                if (data.TryGetValue(value, out outVal) == false)
                {
                    data.Add(value, 0);
                }
                switch (action)
                {
                    case 1:
                        data[value]++;
                        break;
                    case 2:
                        data[value]--;
                        break;
                    case 3:
                        int f = 0;
                        //                        if (data.TryGetValue(value, out outVal))

                        if (data.ContainsValue(value))
                        {
                            f = 1;
                        }

                        res.Add(f);
                        break;
                }
            }

            return res;

        }

        public List<int> freqQuery2(List<int[]> queries)
        {
            List<int> res = new List<int>();
            Dictionary<int, int> data = new Dictionary<int, int>();



            for (int index = 0; index <= queries.Count() - 1; index++)// List<int> query in queries)
            {
                //int action = queries[index][0];
                //int value = queries[index][1];
                switch (queries[index][0])
                {
                    case 1:
                        if (data.ContainsKey(queries[index][1]))
                        {
                            data[queries[index][1]]++;
                        }
                        else
                        {
                            data.Add(queries[index][1], 1);
                        }
                        break;
                    case 2:
                        if (data.ContainsKey(queries[index][1]))
                        {
                            if (data[queries[index][1]] > 0)
                            {
                                data[queries[index][1]]--;
                            }
                        }
                        break;
                    case 3:
                        int freek = queries[index][1];
                        int f = 0;

                        if (data.ContainsValue(freek))
                        {
                            f = 1;
                        }
                        res.Add(f);
                        break;
                }
            }

            return res;

        }

        public List<int> freqQuery3(List<int[]> queries)
        {
            List<int> res = new List<int>();
            Dictionary<int, int> data = new Dictionary<int, int>();
            for (int index = 0; index <= queries.Count() - 1; index++)// List<int> query in queries)
            {
                if (queries[index][0] == 1)
                {
                    if (data.ContainsKey(queries[index][1]))
                    {
                        data[queries[index][1]]++;
                    }
                    else
                    {
                        data.Add(queries[index][1], 1);
                    }
                }
                if (queries[index][0] == 2)
                {
                    if (data.ContainsKey(queries[index][1]))
                    {
                        if (data[queries[index][1]] > 0)
                        {
                            data[queries[index][1]]--;
                        }
                    }
                }
                if (queries[index][0] == 3)
                {
                    int freek = queries[index][1];
                    int f = 0;

                    if (data.ContainsValue(freek))
                    {
                        f = 1;
                    }

                    res.Add(f);
                }
            }

            return res;

        }

        public List<int> freqQuery4(int[][] queries)
        {
            List<int> res = new List<int>();
            Dictionary<int, int> data = new Dictionary<int, int>();
            for (int index = 0; index <= queries.Length - 1; index++)
            {
                int action = queries[index][0];
                int value = queries[index][1];
                int outVal;
                if (data.TryGetValue(value, out outVal) == false)
                {
                    data.Add(value, 0);
                }
                switch (action)
                {
                    case 1:
                        data[value]++;
                        break;
                    case 2:
                        data[value]--;
                        break;
                    case 3:
                        int f = 0;
                        //if (data.TryGetValue(value, out outVal))
                        if (data.ContainsValue(value))
                        {
                            f = 1;
                        }

                        res.Add(f);
                        break;
                }
            }

            return res;

        }

        public List<int> freqQuery5(int[][] queries)
        {
            List<int> res = new List<int>();
            Dictionary<int, int> data = new Dictionary<int, int>();



            for (int index = 0; index <= queries.Length - 1; index++)// List<int> query in queries)
            {
                //int action = queries[index][0];
                //int value = queries[index][1];
                switch (queries[index][0])
                {
                    case 1:
                        if (data.ContainsKey(queries[index][1]))
                        {
                            data[queries[index][1]]++;
                        }
                        else
                        {
                            data.Add(queries[index][1], 1);
                        }
                        break;
                    case 2:
                        if (data.ContainsKey(queries[index][1]))
                        {
                            if (data[queries[index][1]] > 0)
                            {
                                data[queries[index][1]]--;
                            }
                        }
                        break;
                    case 3:
                        int freek = queries[index][1];
                        int f = 0;

                        if (data.ContainsValue(freek))
                        {
                            f = 1;
                        }
                        res.Add(f);
                        break;
                }
            }

            return res;

        }

        public List<int> freqQuery6(int[][] queries)
        {
            List<int> res = new List<int>();
            List<int> vals = new List<int>();
            for (int index = 0; index <= queries.Length - 1; index++)// List<int> query in queries)
            {
                vals.Add(queries[index][1]);
            }

            vals = vals.Distinct().ToList();
            Dictionary<int, int> data = new Dictionary<int, int>();
            for(int index = 0; index <= vals.Count - 1; index++)
            {
                data.Add(vals[index], 0);
            }
            //Dictionary<int, int> data = vals.ToDictionary(k => k, vals => 0);

            int outVal;
            for (int index = 0; index <= queries.Length - 1; index++)// List<int> query in queries)
            {
                int action = queries[index][0];
                int value = queries[index][1];
                switch (action)
                {
                    case 1:
                        data[value]++;
                        break;
                    case 2:
                        if (data[value] > 0)
                        {
                            data[value]--;
                        }
                        break;
                    case 3:
                        int freek = value;
                        int f = 0;

                        if (data.TryGetValue(freek, out outVal) == true)
                        {
                            Console.WriteLine("Hah!");
                        }
                        f = outVal;
                        res.Add(f);
                        break;
                }
            }

            return res;

        }



        public List<int> freqQuery7(List<int[]> queries)
        {
            List<int> res = new List<int>();
            Dictionary<int, int> data = new Dictionary<int, int>();



            for (int index = 0; index <= queries.Count() - 1; index++)// List<int> query in queries)
            {
                //int action = queries[index][0];
                //int value = queries[index][1];
                int outVal;

                switch (queries[index][0])
                {
                    case 1:
                        if (data.TryGetValue(queries[index][1], out outVal))
                        {
                            data[queries[index][1]]++;
                        }
                        else
                        {
                            data.Add(queries[index][1], 1);
                        }
                        break;
                    case 2:
                        if (data.TryGetValue(queries[index][1], out outVal))
                        {
                            if (data[queries[index][1]] > 0)
                            {
                                data[queries[index][1]]--;
                            }
                        }
                        break;
                    case 3:
                        int freek = queries[index][1];
                        int f = 0;

                        if (data.ContainsValue(freek))
                        {
                            f = 1;
                        }
                        res.Add(f);
                        break;
                }
            }

            return res;

        }




    }
}
