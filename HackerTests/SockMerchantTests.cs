using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Tests
{
    [TestClass()]
    public class SockMerchantTests
    {
        [TestMethod()]
        public void migratoryBirdsTest()
        {
            SockMerchant sockM = new SockMerchant();
            int result = sockM.sockMerchant(9, new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 });
            Assert.IsTrue(result == 3);

        }
    }
}