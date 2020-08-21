using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank;

namespace HackerTests
{
    [TestClass]
    public class BreakingRecordsTest
    {
        [TestMethod]
        public void BRone()
        {
            BreakingRecords br = new BreakingRecords();
            int[] records = br.breakingRecords(new int[] { 10, 5, 20, 20, 4, 5, 2, 25, 1 });

            Assert.IsTrue(records[0] == 2 && records[1] == 4);
        }
    }
}
