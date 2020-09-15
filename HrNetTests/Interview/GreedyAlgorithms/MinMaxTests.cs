using Microsoft.VisualStudio.TestTools.UnitTesting;
using HrNet.Interview.GreedyAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HrNet.Interview.GreedyAlgorithms.Tests
{
    [TestClass()]
    public class MinMaxTests
    {
        [TestMethod()]
        public void maxMinTest1()
        {
            MinMax mm = new MinMax();
            int res = mm.maxMin(3, new int[] { 10, 100, 300, 200, 1000, 20, 30 });
            Assert.IsTrue(res == 20);
        }

        [TestMethod()]
        public void maxMinTest2()
        {
            MinMax mm = new MinMax();
            int res = mm.maxMin(4, new int[] { 1, 2, 3, 4, 10, 20, 30, 40, 100, 200 });
            Assert.IsTrue(res == 3);
        }

        [TestMethod()]
        public void maxMinTest3()
        {
            MinMax mm = new MinMax();
            int res = mm.maxMin(2, new int[] { 1, 2, 1, 2, 1 });
            Assert.IsTrue(res == 0);
        }

        [TestMethod()]
        public void maxMinTest4()
        {
            MinMax mm = new MinMax();
            int res = mm.maxMin(5, new int[] { 4504, 1520, 5857, 4094, 4157, 3902, 822, 6643, 2422, 7288, 8245, 9948, 2822, 1784, 7802, 3142, 9739, 5629, 5413, 7232 });
            Assert.IsTrue(res == 1335);
        }


        [TestMethod()]
        public void maxMinTest07()
        {
            string[] lines = File.ReadAllLines(@"./data/min_max/input07.txt");
            int n = Convert.ToInt32(lines[0]);
            int k = Convert.ToInt32(lines[1]);
            int[] arr = new int[n];
            for (int i = 2; i <= n + 1; i++)
            {
                arr[i - 2] = Convert.ToInt32(lines[i]);
            }

            MinMax mm = new MinMax();
            int res = mm.maxMin(k, arr);
            Assert.IsTrue(res == 9665150);
        }

        //[TestMethod()]
        //public void maxMinTest07_2()
        //{
        //    string[] lines = File.ReadAllLines(@"./data/min_max/input07.txt");
        //    int n = Convert.ToInt32(lines[0]);
        //    int k = Convert.ToInt32(lines[1]);
        //    int[] arr = new int[n];
        //    for (int i = 2; i <= n + 1; i++)
        //    {
        //        arr[i - 2] = Convert.ToInt32(lines[i]);
        //    }

        //    MinMax mm = new MinMax();
        //    int res = mm.maxMin2(k, arr);
        //    Assert.IsTrue(res == 9665150);
        //}




    }
}