using Microsoft.VisualStudio.TestTools.UnitTesting;
using HrNet.GreedyAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.GreedyAlgorithms.Tests
{
    [TestClass()]
    public class MinAbsoluteDiffTests
    {
        [TestMethod()]
        public void minimumAbsoluteDifferenceTest1()
        {
            MinAbsoluteDiff mad = new MinAbsoluteDiff();
            int res = mad.minimumAbsoluteDifference(new int[] { -2, 2, 4 });
            Assert.IsTrue(res == 2);
        }
        [TestMethod()]
        public void minimumAbsoluteDifferenceTest2()
        {
            MinAbsoluteDiff mad = new MinAbsoluteDiff();
            int res = mad.minimumAbsoluteDifference(new int[] { 3, - 7, 0 });
            Assert.IsTrue(res == 3);
        }
        [TestMethod()]
        public void minimumAbsoluteDifferenceTest3()
        {
            MinAbsoluteDiff mad = new MinAbsoluteDiff();
            int res = mad.minimumAbsoluteDifference(new int[] { -59, -36, -13, 1, -53, -92, -2, -96, -54, 75 });
            Assert.IsTrue(res == 1);
        }
        [TestMethod()]
        public void minimumAbsoluteDifferenceTest4()
        {
            MinAbsoluteDiff mad = new MinAbsoluteDiff();
            int res = mad.minimumAbsoluteDifference(new int[] { 1, -3, 71, 68, 17 });
            Assert.IsTrue(res == 3);
        }

    }
}