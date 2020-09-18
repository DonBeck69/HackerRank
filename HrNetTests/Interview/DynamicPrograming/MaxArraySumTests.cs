using Microsoft.VisualStudio.TestTools.UnitTesting;
using HrNet.Interview.DynamicPrograming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Interview.DynamicPrograming.Tests
{
    [TestClass()]
    public class MaxArraySumTests
    {
        [TestMethod()]
        public void maxSubsetSumTest()
        {
            MaxArraySum mas = new MaxArraySum();
            int res = mas.maxSubsetSum(new int[] { -2, 1, 3, -4, 5 });
            Assert.IsTrue(res == 8);
        }

        [TestMethod()]
        public void maxSubsetSumTest1()
        {
            MaxArraySum mas = new MaxArraySum();
            int res = mas.maxSubsetSum(new int[] { 3, 7, 4, 6, 5, });
            Assert.IsTrue(res == 13);
        }

        [TestMethod()]
        public void maxSubsetSumTest2()
        {
            MaxArraySum mas = new MaxArraySum();
            int res = mas.maxSubsetSum(new int[] { 2, 1, 5, 8, 4 });
            Assert.IsTrue(res == 11);
        }

        [TestMethod()]
        public void maxSubsetSumTest3()
        {
            MaxArraySum mas = new MaxArraySum();
            int res = mas.maxSubsetSum(new int[] { 2, 1, 5, 8, 4, -6 });
            Assert.IsTrue(res == 11);
        }

        //3 5 -7 8 10
        [TestMethod()]
        public void maxSubsetSumTest4()
        {
            MaxArraySum mas = new MaxArraySum();
            int res = mas.maxSubsetSum(new int[] { 3, 5, -7, 8, 10 });
            Assert.IsTrue(res == 15);
        }

    }
}