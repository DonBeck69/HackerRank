using Microsoft.VisualStudio.TestTools.UnitTesting;
using HrNet.Interview.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Interview.Sorting.Tests
{
    [TestClass()]
    public class BubbleSortTests
    {
        [TestMethod()]
        public void countSwapsTest()
        {
            BubbleSort bs = new BubbleSort();
            int[] a = new int[] { 6, 4, 1};
            int res = bs.countSwaps(ref a);
            Assert.IsTrue(res == 3);
        }

        [TestMethod()]
        public void countSwapsTest2()
        {
            BubbleSort bs = new BubbleSort();
            int[] a = new int[] { 1, 2, 3 };
            int res = bs.countSwaps(ref a);
            Assert.IsTrue(res == 0);
        }


        [TestMethod()]
        public void QuickSortTest1()
        {
            BubbleSort bs = new BubbleSort();
            int[] a = new int[] { 6, 4, 1, 10, 2, 5, 3, 7, 8 };
            bs.StartSort(ref a);
            Assert.IsTrue(a[0] == 1);
        }


    }
}