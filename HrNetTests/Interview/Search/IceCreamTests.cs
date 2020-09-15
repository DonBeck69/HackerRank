using Microsoft.VisualStudio.TestTools.UnitTesting;
using HrNet.Interview.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HrNet.Interview.Search.Tests
{
    [TestClass()]
    public class IceCreamTests
    {
        [TestMethod()]
        public void whatFlavorsTest()
        {
            IceCream ic = new IceCream();
            string res = ic.whatFlavors(new int[] { 1,4,5,3,2 }, 4);
            Assert.IsTrue(res == "1 4");
        }

        [TestMethod()]
        public void whatFlavorsTest2()
        {
            IceCream ic = new IceCream();
            string res = ic.whatFlavors(new int[] { 2, 2, 4, 3 }, 4);
            Assert.IsTrue(res == "1 2");
        }



        [TestMethod()]
        public void whatFlavorsTest02_2()
        {
            IceCream ic = new IceCream();
            string res = ic.whatFlavors(new int[] { 7, 2, 5, 4, 11, }, 12);
            Assert.IsTrue(res == "1 3");
        }

        [TestMethod()]
        public void whatFlavorsTest00()
        {
            string[] lines = File.ReadAllLines(@"./data/ice_cream/input00.txt");
            string[] answers = File.ReadAllLines(@"./data/ice_cream/output00.txt");
            int line = 0;
            int tests = Convert.ToInt32(lines[line++]);
            IceCream ic = new IceCream();
            for (int i = 0; i <= tests - 1; i++)
            {
                int money = Convert.ToInt32(lines[line++]);
                int len = Convert.ToInt32(lines[line++]) - 1;
                string[] flavors = lines[line++].Trim().Split(' ');
                int[] arr = new int[flavors.Length];
                for (int j = 0; j <= len; j++)
                {
                    arr[j] = Convert.ToInt32(flavors[j]);
                }

                string res = ic.whatFlavors(arr, money);
                Assert.IsTrue(res == answers[i].Trim());
            }
        }


    }
}