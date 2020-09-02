using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.InterviewKit.Dictionary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace HackerRank.InterviewKit.Dictionary.Tests
{
    [TestClass()]
    public class TripletsTests
    {
        [TestMethod()]
        public void countTripletsTest1()
        {
            Triplets tr = new Triplets();
            long res = tr.countTriplets(new List<long> { 1, 2, 2, 4 }, 2);
            Assert.IsTrue(res == 2);
        }

        //1 3 9 9 27 81
        [TestMethod()]
        public void countTripletsTest2()
        {
            Triplets tr = new Triplets();
            long res = tr.countTriplets(new List<long> { 1, 3, 9, 9, 27, 81 }, 3);
            Assert.IsTrue(res == 6);
        }

        [TestMethod()]
        public void countTripletsTest3()
        {
            Triplets tr = new Triplets();
            long res = tr.countTriplets(new List<long> { 1, 5, 5, 25, 125 }, 5);
            Assert.IsTrue(res == 4);
        }

        //            string[] lines = File.ReadAllLines(@"./triplets/input02.txt");
        [TestMethod()]
        public void countTripletsTest02()
        {
            string[] lines = File.ReadAllLines(@"./triplets/input02.txt");
            string[] arrs = lines[1].Split(' ');

            long[] arr = new long[arrs.Length];
            for (int index = 0; index <= arrs.Length - 1; index++)
            {
                arr[index] = Convert.ToInt64(arrs[index]);
            }


            Triplets tr = new Triplets();
            long res = tr.countTriplets(arr.ToList(), 1);
            Assert.IsTrue(res == 161700); //171598
        }


        [TestMethod()]
        public void countTripletsTest03()
        {
            string[] lines = File.ReadAllLines(@"./triplets/input03.txt");
            string[] arrs = lines[1].Split(' ');
            long ans = Convert.ToInt64(lines[2]);
            long[] arr = new long[arrs.Length];
            for (int index = 0; index <= arrs.Length - 1; index++)
            {
                arr[index] = Convert.ToInt64(arrs[index]);
            }


            Triplets tr = new Triplets();
            long res = tr.countTriplets(arr.ToList(), 1);
            Assert.IsTrue(res == ans);
        }

        [TestMethod()]
        public void countTripletsTest11()
        {
            string[] lines = File.ReadAllLines(@"./triplets/input11.txt");
            string[] arrs = lines[1].Split(' ');

            long ans = Convert.ToInt64(lines[2]);

            long[] arr = new long[arrs.Length];
            for (int index = 0; index <= arrs.Length - 1; index++)
            {
                arr[index] = Convert.ToInt64(arrs[index]);
            }


            Triplets tr = new Triplets();
            long res = tr.countTriplets(arr.ToList(), 1);
            Assert.IsTrue(res == ans);
        }

        //1667018988625

    }
}