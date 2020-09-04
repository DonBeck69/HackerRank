using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Interview.Sorting
{
    public class FraudActivity
    {

        /// <summary>
        /// This is a sorting challenge, solved by a counting array and not acctualy sorting.
        /// </summary>
        /// <param name="expenditure"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public int activityNotifications(double[] expenditure, int d)
        {
            int res = 0;
            int maxVal = Convert.ToInt32(expenditure.Max());
            double[] countSort = new double[maxVal + 1];
            for (int i = 0; i <= d - 1; i++)
            {
                countSort[(int)expenditure[i]]++;
            }

            for (int index = d; index <= expenditure.Length - 1; index++)
            {
                double median = 0;
                median = GetMedian(d, countSort);
                median = median * 2;
                if (expenditure[index] >= median)
                {
                    res++;
                }

                countSort[(int)expenditure[index]]++;
                countSort[(int)expenditure[index - d]]--;


            }
            return res;
        }

        public double GetMedian(int days, double[] countData)
        {
            double median = 0;
            double count = 0;
            if (days % 2 == 0)
            {
                double m1 = -1;
                double m2 = -1;
                for (int i = 0; i <= countData.Length - 1; i++)
                {
                    count += countData[i];
                    if (m1 == -1 && count >= (days / 2))
                    {
                        m1 = i;
                    }
                    if (m2 == -1 && count >= ((days / 2) + 1))
                    {
                        m2 = i;
                        break;
                    }
                }

                median = (m1 + m2) / 2;

            }
            else
            {
                for (int i = 0; i <= countData.Length - 1; i++)
                {
                    count += countData[i];
                    if (count > (days / 2))
                    {
                        median = i;
                        break;
                    }
                }
            }

            return median;
        }


    }
}
