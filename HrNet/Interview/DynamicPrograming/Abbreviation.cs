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
        public string abbreviation(string a, string b)
        {
            string res = "YES";
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
                        if (matrix[ia, ib] == matrix[ia, ib - 1] + 1)
                        {
                            if (Char.IsUpper(cb[ib - 1]) && Char.IsLower(ca[ia - 1]))
                            {
                                return "NO";
                            }
                        }
                    }
                    else
                    {
                        matrix[ia, ib] = Math.Max(matrix[ia - 1, ib], matrix[ia, ib - 1]);//the highest val behind, or above
                    }
                }
            }


            return res;
        }


        public string abbreviation_Jees(string a, string b)
        {
            string res = "YES";
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
            string diffString = string.Empty;
            int ma = matrix.GetLength(0) - 1;
            int mb = matrix.GetLength(1) - 1;
            bool reduceA1 = true;
            while (ma >= 1)
            {
                reduceA1 = true;
                //a2 = matrix.GetLength(1) - 1;
                while (mb >= 1)
                {
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

                    else if (matrix[ma, mb] == matrix[ma - 1, mb - 1] && matrix[ma, mb] == matrix[ma, mb - 1] && matrix[ma, mb] == matrix[ma - 1, mb])
                    {
                        return "NO"; //letter in b is not in a, cannot remove from b
                    }

                    //else if (matrix[ma, mb] == matrix[ma, mb - 1] && matrix[ma - 1, mb] == matrix[ma - 1, mb - 1])
                    else if (matrix[ma, mb] - 1 == matrix[ma - 1, mb - 1] && matrix[ma, mb] == matrix[ma - 1, mb - 1])
                    {
                        if (Char.IsUpper(ca[ma - 1]) && Char.IsUpper(cb[mb - 1]))
                        {
                            if (ca[ma - 1] != cb[mb - 1])
                            {
                                return "NO"; // abort, b is not in a and is upper
                            }
                        }

                        if (Char.IsUpper(ca[ma - 1]) && Char.IsLower(cb[mb - 1]))
                        {
                            if (ca[ma - 1] == cb[mb - 1])
                            {
                                return "NO"; // abort, b lower case and a is uppercase, cannot LC a, just UC a
                            }
                        }

                        diffString = $"{ca[ma - 1]}{diffString}";
                        ma--;
                        reduceA1 = false;
                        break;

                    }

                    return "NO"; // abort, letter in b that is not in a.
                    //a2--;
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
