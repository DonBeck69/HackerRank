using Microsoft.VisualStudio.TestTools.UnitTesting;
using HrNeT.Interview.GreedyAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HrNet.Interview.GreedyAlgorithms.Tests
{
    [TestClass()]
    public class GreedyFloristTests
    {
        [TestMethod()]
        public void getMinimumCostTest()
        {
            GreedyFlorist gf = new GreedyFlorist();
            long res = gf.getMinimumCost(3, new int[] { 1, 3, 5, 7, 9 });
            Assert.IsTrue(res == 29);
        }

        [TestMethod()]
        public void getMinimumCostTest01()
        {
            string[] lines = File.ReadAllLines(@"./greedy_florist/input01.txt");
            string[] s = lines[0].Split(' ');
            int cust = Convert.ToInt32(s[1]);
            string[] sow = lines[1].Split(' ');
            int[] flowers = new int[sow.Length];
            for (int i = 0; i <= sow.Length - 1; i++)
            {
                flowers[i] = Convert.ToInt32(sow[i]);
            }

            GreedyFlorist gf = new GreedyFlorist();
            long res = gf.getMinimumCost(cust, flowers);
            Assert.IsTrue(res == 163578911);
        }

    }

}