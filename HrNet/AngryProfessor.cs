using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/angry-professor/problem
    /// </summary>
    public class AngryProfessor
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="k"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public  string angryProfessor(int k, int[] a)
        {
            string res = "YES";
            int onTime = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] < 1)
                {
                    onTime++;
                }

                if(onTime >= k)
                {
                    res = "NO";
                    break;
                }
            }

            return res;
        }
    }
}
