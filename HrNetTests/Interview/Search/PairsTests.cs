using Microsoft.VisualStudio.TestTools.UnitTesting;
using HrNet.Interview.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Interview.Search.Tests
{
    [TestClass()]
    public class PairsTests
    {
        [TestMethod()]
        public void pairsTest()
        {
            Pairs pairs = new Pairs();
            int res = pairs.pairs(2, new int[] { 1, 5, 3, 4, 2 });
            Assert.IsTrue(res == 3);
        }
        [TestMethod()]
        public void pairsTest2()
        {
            Pairs pairs = new Pairs();
            int res = pairs.pairs(2, new int[] { 7, 3, 2, 1, 4 });
            Assert.IsTrue(res == 2);
        }
    }
}