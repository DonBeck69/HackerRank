using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class BonApitite
    {
        public string bonAppetit(List<int> bill, int k, int b)
        {
            string result = "Bon Appetit";
            bill.Remove(bill[k]);
            double fair = bill.Sum() / 2;
            if (fair != b)
            {
                result = (b - fair).ToString();
            }

            Console.WriteLine(result);

            return result;
        }
    }
}
