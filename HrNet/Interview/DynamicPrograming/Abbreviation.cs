using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Interview.DynamicPrograming
{
    public class Abbreviation
    {
        /// <summary>
        /// Longest Common Subsequence
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// 
        public string abbreviation(string a, string b)
        {
            string res = "NO";

            //a = a.Reverse();

            char[] ca = a.ToCharArray();
            int filled = 0;
            char[] cb = b.ToCharArray();
            char[] result = new char[a.Length];

            Dictionary<int, char> caps = new Dictionary<int, char>();
            Dictionary<int, char> capsUsed = new Dictionary<int, char>();
            Dictionary<int, char> lows = new Dictionary<int, char>();

            //separate the caps and lowers
            for (int i = 0; i <= ca.Length - 1; i++)
            {
                if (char.IsUpper(ca[i]))
                {
                    caps.Add(i, ca[i]);
                } 
                else
                {
                    lows.Add(i, ca[i]);
                }
            }

            
            //fill result with caps 1st
            for (int ib = 0; ib <= cb.Length - 1; ib++)
            {
                for(int i = 0; i <= caps.Count - 1; i++)// KeyValuePair<int, char> cap in caps)
                {
                    KeyValuePair<int, char> cap = caps.ElementAt(i);
                    if (b[ib] == cap.Value)
                    {
                        result[ib] = cap.Value;
                        filled++;
                        capsUsed.Add(cap.Key, cap.Value);
                        caps.Remove(cap.Key);
                        i--;
                        break;
                    }
                }

                if (caps.Count == 0)
                {
                    break;
                }
            }


            if (filled == cb.Length)
            {
                return "YES";
            }

            if (caps.Count > 0)
            {
                return res;
            }    


            //fill in the lowers.
            for (int ib = 0; ib <= cb.Length - 1; ib++)
            {
                if (capsUsed.Count > 0 && result[ib] == capsUsed.First().Value)
                {
                    capsUsed.Remove(capsUsed.First().Key);
                    continue;
                }
                for (int i = 0; i <= lows.Count - 1; i++)// KeyValuePair<int, char> cap in caps)
                {
                    KeyValuePair<int, char> low = lows.ElementAt(i);
                    if (result[ib] == 0)
                    {
                        if (b[ib] == low.Value)
                        {
                            result[ib] = low.Value;
                            filled++;
                            lows.Remove(low.Key);
                            i--;
                            break;
                        }
                    }
                }

                if (lows.Count == 0)
                {
                    break;
                }
            }






            return res;
        }



        public string abbreviation2(string a, string b)
        {
            string res = "NO";

            //a = a.Reverse();
            List<char> subs = new List<char>();

            char[] ca = a.ToCharArray();
            char[] cb = b.ToCharArray();



            int ia = 0;
            int ib = 0;

            bool found = false;
            while (ia <= ca.Length - 1)
            {
                if(char.ToLower(ca[ia]) == char.ToLower(cb[ib]))
                {
                    if (char.IsLower(cb[ib]) && char.IsUpper(ca[ia]))
                    {
                        ia++;
                        ib = 0;
                        subs.Clear();
                        continue;
                    }
                    else if (char.IsUpper(cb[ib]))
                    {

                    }

                    else
                    {
                        ia++;
                        if(ib < cb.Length - 1)
                        {
                            subs.Add(cb[ib]);
                            ib++;

                        }
                        else
                        {
                            found = true;
                        }
                        continue;
                    }
                }
                else if(char.IsUpper(ca[ia]))
                {
                    found = false;
                    break;
                }

                ia++;
            }

            if(found)
            {
                res = "YES";
            }

            return res;
        }

        public string abbreviation_gah(string a, string b)
        {
            string res = "YES";

            //a = a.Reverse();

            
            char[] ca = a.ToCharArray();
            char[] cb = b.ToCharArray();

            int[,] matrix = new int[ca.Length + 1, cb.Length + 1];

            for (int ia = 1; ia <= ca.Length; ia++)
            {
                for (int ib = 1; ib <= cb.Length; ib++)
                {
                    //just looking for letter match here.
                    if (Char.ToLower(ca[ia - 1]) == Char.ToLower(cb[ib - 1]))
                    {
                        matrix[ia, ib] = matrix[ia - 1, ib - 1] + 1;
                    }
                    else
                    {
                        matrix[ia, ib] = Math.Max(matrix[ia - 1, ib], matrix[ia, ib - 1]);//the highest val behind, or above
                    }
                }
            }

            // reconstruct common subsequence
            //string subString = string.Empty;
            //List<string> mabey = new List<string>
            int ma = matrix.GetLength(0) - 1;
            int mb = matrix.GetLength(1) - 1;
            bool reduceA1 = true;
            while (ma >= 1)
            {
                reduceA1 = true;
                //a2 = matrix.GetLength(1) - 1;
                while (mb >= 1)
                {
                    //finds a match
                    if (matrix[ma, mb] - 1 == matrix[ma - 1, mb - 1] && matrix[ma, mb] - 1 == matrix[ma, mb - 1] && matrix[ma, mb] - 1 == matrix[ma - 1, mb])
                    {
                        //subString = $"{sa2[a2 - 1]}{subString}";
                        if (Char.IsUpper(ca[ma - 1]) && Char.IsLower(cb[mb - 1]))
                        {
                            return "NO"; // abort, UC letter in a and LC letter in b. cannot change b to upper
                        }
                        ma--;
                        mb--;
                        reduceA1 = false;
                        break;
                    }

                    // if all are equal, no match, check for upper case left and top
                    // 2, 2
                    // 2, 2
                    else if (matrix[ma, mb] == matrix[ma - 1, mb - 1] && matrix[ma, mb] == matrix[ma, mb - 1] && matrix[ma, mb] == matrix[ma - 1, mb])
                    {
                        if (Char.IsUpper(ca[ma - 1]) || Char.IsUpper(cb[mb - 1]))
                        {
                            return "NO"; //letter in b is not in a, cannot remove from b
                        }

                        ma--;
                        mb--;
                        reduceA1 = false;
                        break;
                    }

                    //if left top and bottom are 1 less than right, move up if b not upper
                    // 2, 3
                    // 2, 3
                    else if (matrix[ma - 1, mb - 1] == matrix[ma, mb - 1] && matrix[ma, mb] == matrix[ma - 1, mb] && matrix[ma, mb] - 1 == matrix[ma, mb - 1])
                    {
                        if (Char.IsUpper(ca[ma - 1]))
                        {
                            return "NO"; // abort, b is not in a and is upper
                        }

                        ma--;
                        reduceA1 = false;
                        break;
                    }

                    //if bottom left and right are 1 equal and one more than top right = left , move left
                    // for this function though, abort, cannot change A
                    // 2, 2
                    // 3, 3
                    else if (matrix[ma - 1, mb - 1] == matrix[ma - 1, mb] && matrix[ma, mb] == matrix[ma, mb - 1] && matrix[ma, mb] - 1 == matrix[ma - 1, mb])
                    {
                        return "NO"; // abort, b is not in a and is upper
                    }

                    mb--;

                }

                if (reduceA1)
                {
                    ma--;
                }
            }

            return res;
        }


        public string abbreviation_full(string a, string b)
        {
            string res = "YES";
            char[] sa1 = a.ToCharArray();
            char[] sa2 = b.ToCharArray();
            int[,] matrix = new int[sa1.Length + 1, sa2.Length + 1];

            for (int i1 = 1; i1 <= sa1.Length; i1++)
            {
                for (int i2 = 1; i2 <= sa2.Length; i2++)
                {
                    //just looking for letter match here.
                    if (Char.ToLower(sa1[i1 - 1]) == Char.ToLower(sa2[i2 - 1]))
                    {
                        matrix[i1, i2] = matrix[i1 - 1, i2 - 1] + 1;
                    }
                    else
                    {
                        matrix[i1, i2] = Math.Max(matrix[i1 - 1, i2], matrix[i1, i2 - 1]);//the highest val behind, or above
                    }
                }
            }

            // reconstruct common subsequence
            string subString = string.Empty;
            string diffString = string.Empty;
            int a1 = matrix.GetLength(0) - 1;
            int a2 = matrix.GetLength(1) - 1;
            bool reduceA1 = true;
            while (a1 >= 1)
            {
                reduceA1 = true;
                //a2 = matrix.GetLength(1) - 1;
                while (a2 >= 1)
                {
                    if (matrix[a1, a2] - 1 == matrix[a1 - 1, a2 - 1] && matrix[a1, a2] - 1 == matrix[a1, a2 - 1] && matrix[a1, a2] - 1 == matrix[a1 - 1, a2])
                    {
                        subString = $"{sa2[a2 - 1]}{subString}";
                        a1--;
                        a2--;
                        reduceA1 = false;
                        break;
                    }

                    else if (matrix[a1, a2] == matrix[a1 - 1, a2 - 1] && matrix[a1, a2] == matrix[a1, a2 - 1] && matrix[a1, a2] == matrix[a1 - 1, a2])
                    {
                        diffString = $"{sa1[a1 - 1]}{diffString}";

                        a1--;
                        reduceA1 = false;
                        break;
                    }

                    else if (matrix[a1, a2] - 1 == matrix[a1 - 1, a2 - 1] && matrix[a1, a2] == matrix[a1 - 1, a2])
                    {
                        diffString = $"{sa1[a1 - 1]}{diffString}";
                        a1--;
                        reduceA1 = false;
                        break;
                    }

                    diffString = $"{sa2[a2 - 1]}{diffString}";
                    a2--;
                }

                if (reduceA1)
                {
                    a1--;
                }
            }

            //Console.WriteLine(diffString);

            //if there is no ongest Common Subsequence then then stick with no.
            if (diffString.Length > 0)
            {
                char[] diffChar = diffString.ToCharArray();
                foreach (char diff in diffChar)
                {
                    if (Char.IsUpper(diff))
                    {
                        res = "NO";
                        break;
                    }
                }
            }



            return res;
        }


        //BFZZVHdQYHQEMNEFFRFJTQmNWHFVXRXlGTFNBqWQmyOWYWSTDSTMJRYHjBNTEWADLgHVgGIRGKFQSeCXNFNaIFAXOiQORUDROaNoJPXWZXIAABZKSZYFTDDTRGZXVZZNWNRHMvSTGEQCYAJSFvbqivjuqvuzafvwwifnrlcxgbjmigkms
        //BFZZVHQYHQEMNEFFRFJTQNWHFVXRXGTFNBWQOWYWSTDSTMJRYHBNTEWADLHVGIRGKFQSCXNFNIFAXOQORUDRONJPXWZXIAABZKSZYFTDDTRGZXVZZNWNRHMSTGEQCYAJSF

        //DLgHVgGIR
        //DLHVGIR


    }
}
