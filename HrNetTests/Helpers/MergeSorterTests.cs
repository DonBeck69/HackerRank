using Microsoft.VisualStudio.TestTools.UnitTesting;
using HrNet.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Helpers.Tests
{
    [TestClass()]
    public class MergeSorterTests
    {
        [TestMethod()]
        public void SortTest()
        {
            int[] uns = new[] { 8, 7, 1, 5, 3, 6, 9, 4, 2 };
            MergeSorter mergeSorter = new MergeSorter();
            int[] sor = mergeSorter.Sort(uns);
            Assert.IsTrue(sor[0] == 1);
            Assert.IsTrue(sor[3] == 4);
            Assert.IsTrue(sor[8] == 9);
        }
    }
}