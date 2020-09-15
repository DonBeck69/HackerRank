using Microsoft.VisualStudio.TestTools.UnitTesting;
using HrNeT.Interview.GreedyAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Interview.GreedyAlgorithms.Tests
{
    [TestClass()]
    public class LuckBalanceTests
    {
        [TestMethod()]
        public void luckBalanceTest()
        {
            LuckBalance lb = new LuckBalance();
            int[][] contests = new int[6][];
            contests[0] = new int[2] { 5, 1 };
            contests[1] = new int[2] { 2, 1 };
            contests[2] = new int[2] { 1, 1 };
            contests[3] = new int[2] { 8, 1 };
            contests[4] = new int[2] { 10, 0 };
            contests[5] = new int[2] { 5, 0 };

            int res = lb.luckBalance(3, contests);
            Assert.IsTrue(res == 29);
        }
    }
}