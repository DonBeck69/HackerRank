using Microsoft.VisualStudio.TestTools.UnitTesting;
using HrNet.Interview.DynamicPrograming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HrNet.Interview.DynamicPrograming.Tests
{
    [TestClass()]
    public class CandiesTests
    {
        [TestMethod()]
        public void candiesTest()
        {
            Candies candies = new Candies();
            int[] arr = new int[] { 4, 6, 4, 5, 6, 2 };
            long res = candies.candies(arr.Length, arr);
            Assert.IsTrue(res == 10);
        }

        [TestMethod()]
        public void candiesTest0()
        {
            Candies candies = new Candies();
            int[] arr = new int[] { 1, 2, 2 };
            long res = candies.candies(arr.Length, arr);
            Assert.IsTrue(res == 4);
        }
        [TestMethod()]
        public void candiesTest1()
        {
            Candies candies = new Candies();
            int[] arr = new int[] { 2, 4, 2, 6, 1, 7, 8, 9, 2, 1 };
            long res = candies.candies(arr.Length, arr);
            Assert.IsTrue(res == 19);
        }
        

        [TestMethod()]
        public void candiesTest2()
        {
            Candies candies = new Candies();
            int[] arr = new int[] { 2, 4, 3, 5, 2, 6, 4, 5 };
            long res = candies.candies(arr.Length, arr);
            Assert.IsTrue(res == 12);
        }
        //
        [TestMethod()]
        public void candiesTest3()
        {
            Candies candies = new Candies();
            int[] arr = new int[] { 4, 4, 2, 3, 4, 1 };
            long res = candies.candies(arr.Length, arr);
            Assert.IsTrue(res == 10);
        }
        [TestMethod()]
        public void candiesTest4()
        {
            Candies candies = new Candies();
            int[] arr = new int[] { 5, 5, 4, 3, 2, 2, 3, 4 };
            long res = candies.candies(arr.Length, arr);
            Assert.IsTrue(res == 17);
        }

        [TestMethod()]
        public void candiesTest5()
        {
            Candies candies = new Candies();
            int[] arr = new int[] { 4, 4, 2, 1, 3, 4, 1 };
            long res = candies.candies(arr.Length, arr);
            Assert.IsTrue(res == 13);
        }


        [TestMethod()]
        public void candiesTest6()
        {
            Candies candies = new Candies();
            int[] arr = new int[] { 5, 6, 7, 7, 6, 5, 4, 5, 6, 5,4 };
            long res = candies.candies(arr.Length, arr);
            Assert.IsTrue(res == 24);
        }

        [TestMethod()]
        public void candiesTest7()
        {
            Candies candies = new Candies();
            int[] arr = new int[] { 2, 1, 1 };
            long res = candies.candies(arr.Length, arr);
            Assert.IsTrue(res == 4);
        }

        [TestMethod()]
        public void candiesTest8()
        {
            Candies candies = new Candies();
            int[] arr = new int[] { 1, 1, 2 };
            long res = candies.candies(arr.Length, arr);
            Assert.IsTrue(res == 4);
        }




        [TestMethod()]
        public void substrCountTest01()
        {
            string[] lines = File.ReadAllLines(@"./data/candies/input01.txt");
            int len = Convert.ToInt32(lines[0]);

            int[] arr = new int[len];
            for (int i = 1; i <= lines.Length - 1; i++)
            {
                arr[i - 1] = Convert.ToInt32(lines[i]);
            }

            Candies candies = new Candies();
            //string s = "aaabaaca";
            long res = candies.candies(len, arr);
            Assert.IsTrue(res == 33556);
        }


    }
}


