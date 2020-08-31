using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Tests
{
    [TestClass()]
    public class BonApititeTests
    {
        [TestMethod()]
        public void bonAppetitTest()
        {
            BonApitite bonApitite = new BonApitite();
            string result = bonApitite.bonAppetit(new List<int>() { 3, 10, 2, 9 }, 1, 7);
            Assert.IsTrue(result == "Bon Appetit");
        }

        [TestMethod()]
        public void bonAppetitTest2()
        {
            BonApitite bonApitite = new BonApitite();
            string result = bonApitite.bonAppetit(new List<int>() { 3, 10, 2, 9 }, 1, 12);
            Assert.IsTrue(result == "5");
        }

        [TestMethod()]
        public void bonAppetitTest3()
        {
            BonApitite bonApitite = new BonApitite();
            string result = bonApitite.bonAppetit(new List<int>() { 4, 10, 2, 9 }, 1, 12);
            Assert.IsTrue(result == "5");
        }


    }
}