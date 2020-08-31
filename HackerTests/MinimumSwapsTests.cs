using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank;
using System;
using System.Collections.Generic;
using System.IO;

using System.Text;

namespace HackerRank.Tests
{
    [TestClass()]
    public class MinimumSwapsTests
    {
        [TestMethod()]
        public void minimumSwapsTest()
        {
            MinimumSwaps ms = new MinimumSwaps();
            int[] arr = new int[] { 4, 3, 1, 2, };
            int result = ms.minimumSwaps(arr);

            Assert.IsTrue(result == 3);
        }



        [TestMethod()]
        public void minimumSwapsTest2()
        {
            MinimumSwaps ms = new MinimumSwaps();
            int[] arr = new int[] { 2, 3, 4, 1, 5 };
            int result = ms.minimumSwaps(arr);

            Assert.IsTrue(result == 3);
        }

        [TestMethod()]
        public void minimumSwapsTest3()
        {
            MinimumSwaps ms = new MinimumSwaps();
            int[] arr = new int[] { 1, 3, 5, 2, 4, 6, 7 };
            int result = ms.minimumSwaps(arr);

            Assert.IsTrue(result == 3);
        }



        [TestMethod()]
        public void minimumSwapsTest09()
        {
            string[] lines = File.ReadAllLines(@"./MinSwaps/input09.txt");
            string[] arrs = lines[1].Split(' ');
            int[] arr = new int[arrs.Length];
            for(int index = 0; index <= arrs.Length - 1; index++)
            {
                arr[index] = Convert.ToInt32(arrs[index]);
            }

            MinimumSwaps ms = new MinimumSwaps();
            int result = ms.minimumSwaps(arr);

            Assert.IsTrue(result == 49990);
        }


        [TestMethod()]
        public void minimumSwapsTest10()
        {
            string[] lines = File.ReadAllLines(@"./MinSwaps/input10.txt");
            string[] arrs = lines[1].Split(' ');
            int[] arr = new int[arrs.Length];
            for (int index = 0; index <= arrs.Length - 1; index++)
            {
                arr[index] = Convert.ToInt32(arrs[index]);
            }

            MinimumSwaps ms = new MinimumSwaps();
            int result = ms.minimumSwaps(arr);

            Assert.IsTrue(result == 99984);
        }



    }
}