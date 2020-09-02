using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Tests
{
    [TestClass()]
    public class BribeNewYearChaosTests
    {
        [TestMethod()]
        public void minimumBribesTest1()
        {
            BribeNewYearChaos bc = new BribeNewYearChaos();
            int[] q = new int[] { 2, 1, 5, 3, 4 };
            string result = bc.minimumBribes(q);
            Assert.IsTrue(result == "3");
        }

        [TestMethod()]
        public void minimumBribesTest2()
        {
            BribeNewYearChaos bc = new BribeNewYearChaos();
            int[] q = new int[] { 2, 5, 1, 3, 4 };
            string result = bc.minimumBribes(q);
            Assert.IsTrue(result == "Too chaotic");
        }

        [TestMethod()]
        public void minimumBribesTest3()
        {
            BribeNewYearChaos bc = new BribeNewYearChaos();
            int[] qq = new int[] { 1, 2, 5, 3, 7, 8, 6, 4 };
            string result = bc.minimumBribes(qq);
            Assert.IsTrue(result == "7");
        }


    }
}