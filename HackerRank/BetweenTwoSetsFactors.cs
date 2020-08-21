using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class BetweenTwoSetsFactors
    {

        public List<int> getBetweenNumbers(List<int> a, List<int> b)
        {
            a.Sort();
            b.Sort();
            List<int> result = new List<int>();
            //List<int> bfactors = new List<int>();
            // get all factors of the 2nd array
            List<List<int>> bfl = new List<List<int>>();

            foreach (int factor in b)
            {
                List<int> bf = GetFactors(factor);
                bfl.Add(bf);
            }

            // only use factors that are common for all values of b...
            List<int> sharedFactorsB = GetSharedNumbers2(bfl);

            //use sharedFactorsB to get all divisors of a
            //List<List<int>> sharedFactorsA = new List<List<int>>();
            List<int> sharedFactorsA = new List<int>();
            foreach (int bf in sharedFactorsB)
            {
                //List<int> sfa = new List<int>();
                //int sfa = 0;
                bool found = false;
                foreach (int an in a)
                {
                    //if (bf >= an)
                    //{
                        if (bf % an == 0)
                        {
                            //sfa.Add(an);
                            found = true;
                        }
                        else
                        {
                            found = false;
                            break;
                        }
                    //}
                }

                if (found)
                {
                    if (sharedFactorsA.Contains(bf) == false)
                    {
                        sharedFactorsA.Add(bf);
                    }
                }
            }

            //result = GetSharedNumbers(sharedFactorsA);


             return sharedFactorsA;
        }

        public List<int> GetFactors(int Tnumber)
        {
            List<int> divisorCount = new List<int>();

            double sqirt = Math.Ceiling(Math.Sqrt(Tnumber));
            for (int factor = 1; factor <= sqirt; factor++)
            {
                if (Tnumber % factor == 0)
                {
                    divisorCount.Add(factor);
                }

                if (Tnumber % (Tnumber / factor) == 0)
                {
                    divisorCount.Add(Tnumber / factor);
                }
            }

            divisorCount = divisorCount.Distinct().ToList();
            divisorCount.Sort();
            return divisorCount;

        }

        public List<int> GetSharedNumbers2(List<List<int>> Factors)
        {
            List<int> result = Factors[0];
            for (int index = 0; index <= Factors.Count - 2; index++)
            {
                result = result.Intersect(Factors[index + 1]).ToList();
            }

            return result;
        }

        // could have / should  used List.Intersect...
        public List<int> GetSharedNumbers(List<List<int>> Factors)
        {
            List<int> result = new List<int>();
            for (int index = 0; index <= Factors.Count - 2; index++)
            {
                List<int> f;// = new List<int>();

                if (index == 0)
                {
                   f = Factors[index];
                }
                else
                {
                    f = result;
                }

                List<int> s = Factors[index + 1];

                foreach (int n in f)
                {
                    if (s.Contains(n))
                    {
                        if (result.Contains(n) == false)
                        {
                            result.Add(n);
                        }
                    }
                    else if (result.Contains(n))
                    {
                        result.Remove(n);// remove numbers that are in result but not in current "second" s array 
                    }
                }
            }

            return result;
        }

    }
}
