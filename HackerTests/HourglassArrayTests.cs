using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Tests
{
    [TestClass()]
    public class HourglassArrayTests
    {
        [TestMethod()]
        public void hourglassSumTest1()
        {
            HourglassArray hg = new HourglassArray();

            int[][] arr = new int[6][];
            arr[0] = new int[] { -9, -9, -9, 1, 1, 1 };
            arr[1] = new int[] { 0, - 9,  0,  4, 3, 2 };
            arr[2] = new int[] { -9, - 9, - 9,  1, 2, 3 };
            arr[3] = new int[] { 0, 0, 8,  6, 6, 0 };
            arr[4] = new int[] { 0, 0, 0, - 2, 0, 0 };
            arr[5] = new int[] { 0, 0, 1, 2, 4, 0 };

            int result = hg.hourglassSum(arr);

            Assert.IsTrue(result == 28);
        }

        [TestMethod()]
        public void hourglassSumTest2()
        {
            HourglassArray hg = new HourglassArray();

            int[][] arr = new int[6][];
            arr[0] = new int[] { 1, 1, 1, 0, 0, 0 };
            arr[1] = new int[] { 0, 1, 0, 0, 0, 0 };
            arr[2] = new int[] { 1, 1, 1, 0, 0, 0 };
            arr[3] = new int[] { 0, 0, 2, 4, 4, 0 };
            arr[4] = new int[] { 0, 0, 0, 2, 0, 0 };
            arr[5] = new int[] { 0, 0, 1, 2, 4, 0 };

            int result = hg.hourglassSum(arr);

            Assert.IsTrue(result == 19);
        }
    }
}