using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class GradingStudents
    {
        public List<int> GetGrades(List<int> grades)
        {
            List<int> graded = new List<int>();

            for (int index = 1; index <= grades.Count - 1; index++)
            {
                string s = "abc";
                char[] sa = s.ToCharArray();
                int grade = grades[index];
                int modGrade = grade;
                if (modGrade > 37)
                {
                    //if not divisible by 5, find next multiple of 5
                    if (modGrade % 5 != 0)
                    {
                        while (modGrade % 5 != 0)
                        {
                            modGrade++;
                        }
                    }

                    // check diff
                    if (modGrade - grade > 2)
                    {
                        modGrade = grade;
                    }
                    
                }

                //add grade
                graded.Add(modGrade);
            }

            return graded;
        }

    }
}