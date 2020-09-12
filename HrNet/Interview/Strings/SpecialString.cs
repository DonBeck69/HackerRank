using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace HrNet.Interview.Strings
{
    public class SpecialString
    {
        public long substrCount(int n, string s)
        {
            long res = n;
            //much faster and easier to loop through
            char[] letters = s.ToCharArray();
            int letterIndex = letters.Length - 1;

            // all the single letters
            for (int i = 0; i <= letterIndex; i++)
            {
                int sideIndex = 1;
                bool checkedAll = false;
                //get score for same, same letters "aaa"
                int sameLeft = i;
                int sameRight = 0;

                while (checkedAll == false)
                {
                    //outside bounds
                    if (i + sideIndex > letterIndex)
                    {
                        checkedAll = true;
                    }
                    else
                    {
                        // check letter 1 space ahead is =
                        if (letters[i + sideIndex] == letters[i])
                        {
                            sameRight = i + sideIndex;
                            //i++;
                            sideIndex++;
                        }
                        else
                        {
                            checkedAll = true;
                        }
                    }
                }

                //calculate score based off length of same letters
                // hint: its a formula aaaa = len-1 = 3(len-1)+2+1 etc
                int score = 0;
                int foundSameLen = (sameRight - sameLeft) + 1;
                if (foundSameLen > 2)
                {
                    i += foundSameLen - 1;
                }
                if (foundSameLen > 0)
                {
                    while (foundSameLen >= 1)
                    {
                        foundSameLen--;
                        score += foundSameLen;
                    }
                    res += score;
                }




                //now look aaaQaaa - special string
                checkedAll = false;
                score = 0;
                //int foundLetterindex = 0;
                while (checkedAll == false)
                {
                    //outside bounds (left and right)
                    if (i - sideIndex < 0 || i + sideIndex > letterIndex)
                    {
                        checkedAll = true;
                    }
                    else
                    {
                        //is if, aabaa, is aba 1 and aabaa anouther?
                        //make sure there is not cabac...
                        if (letters[i - sideIndex] == letters[i + sideIndex] && letters[i + sideIndex] != letters[i])
                        {
                            bool samesame = true;
                            for (int sindex = i + sideIndex - 1; sindex > i; sindex--)
                            {
                                if (letters[sindex] != letters[i + sideIndex])
                                {
                                    samesame = false;
                                    checkedAll = true;
                                    break;
                                }
                            }
                            if (samesame)
                            { 
                                //foundLetterindex = letters[i - sideIndex];
                                sideIndex++;
                                score++;
                            }
                        }
                        else
                        {
                            checkedAll = true;
                        }
                    }
                }

                res += score;

            }

            return res;

        }
    }
}
