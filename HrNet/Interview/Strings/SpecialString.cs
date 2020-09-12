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

        /// <summary>
        /// SEXY with Donovan stank
        /// </summary>
        /// <param name="n"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public long substrCount(int n, string s)
        {
            long ret = n;
            char[] letters = s.ToCharArray();

            for (int index = 0; index < n; index++)
            {
                var letter = letters[index];
                int positionCheck = -1;
                for (int scanIndex = index + 1; scanIndex < n; scanIndex++)
                {
                    var scanLetter = letters[scanIndex];
                    if (letter == scanLetter)
                    {
                        if ((positionCheck == -1) || (scanIndex - positionCheck) == (positionCheck - index))
                            ret++;
                    }
                    else
                    {
                        if (positionCheck == -1)
                            positionCheck = scanIndex;
                        else
                            break;
                    }
                }
            }
            return ret;
        }

        /// <summary>
        /// SEXY
        /// </summary>
        /// <param name="n"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public long stolen(int n, string s)
        {
            long retVal = n;

            for (int i = 0; i < s.Length; i++)
            {
                var startChar = s[i];
                int checkIndex = -1;
                for (int j = i + 1; j < n; j++)
                {
                    var currChar = s[j];
                    if (startChar == currChar)
                    {
                        if ((checkIndex == -1) || (j - checkIndex) == (checkIndex - i))
                            retVal++;
                    }
                    else
                    {
                        if (checkIndex == -1)
                            checkIndex = j;
                        else
                            break;
                    }
                }
            }
            return retVal;
        }


        /// <summary>
        /// Hactastic and buggy
        /// </summary>
        /// <param name="n"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public long substrCountHack(int n, string s)
        {
            long res = n;
            //much faster and easier to loop through
            char[] letters = s.ToCharArray();
            long letterIndex = letters.Length - 1;

            // all the single letters
            for (long i = 0; i <= letterIndex; i++)
            {
                long sideIndex = 1;
                bool checkedAll = false;
                //get score for same, same letters "aaa"
                long sameLeft = i;
                long sameRight = 0;

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
                long score = 0;
                long foundSameLen = (sameRight - sameLeft) + 1;
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
                            for (long sindex = i + sideIndex - 1; sindex > i; sindex--)
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
