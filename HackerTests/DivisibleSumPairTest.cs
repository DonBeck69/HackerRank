using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank;

namespace HackerTests
{
    [TestClass]
    public class DivisibleSumPairTest
    {
        [TestMethod]
        public void one()
        {
            DivisibleSumPairs theThing = new DivisibleSumPairs();
            int records = theThing.divisibleSumPairs(6, 5, new int[] { 1, 2, 3, 4, 5, 6 });

            Assert.IsTrue(records == 3);
        }
        [TestMethod]
        public void two()
        {
            DivisibleSumPairs theThing = new DivisibleSumPairs();
            int records = theThing.divisibleSumPairs(6, 3, new int[] { 1, 3, 2, 6, 1, 2 });

            Assert.IsTrue(records == 5);
        }
    }
}
