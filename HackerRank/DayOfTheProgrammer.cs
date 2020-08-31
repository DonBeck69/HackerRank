using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Text;

namespace HackerRank
{
    public class DayOfTheProgrammer
    {
        public string dayOfProgrammer(int year)
        {
            string day = string.Empty;
            DateTime pdate = new DateTime(year, 1, 1);
            int daysToAdd = 255; 

            // specific to Russia...
            if(year == 1918)
            {
                daysToAdd += 13;
            }
            else if (year <= 1917)
            {
                if (DateTime.IsLeapYear(year) == false && year % 4 == 0)
                {
                    daysToAdd--;
                }
            }

            pdate = pdate.AddDays(daysToAdd);
            day = pdate.ToString("dd.MM.yyyy");

            return day;

        }
    }
}
