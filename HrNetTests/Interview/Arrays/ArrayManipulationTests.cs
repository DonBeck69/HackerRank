using Microsoft.VisualStudio.TestTools.UnitTesting;
using HrNet.Interview.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HrNet.Interview.Arrays.Tests
{
    [TestClass()]
    public class ArrayManipulationTests
    {
        [TestMethod()]
        public void arrayManipulationTest()
        {
            ArrayManipulation am = new ArrayManipulation();
            int[][] q = new int[3][];
            q[0] = new int[] { 1, 5, 3 };
            q[1] = new int[] { 4, 8, 7 };
            q[2] = new int[] { 6, 9, 1 };
            long res = am.arrayManipulation(10, q);
            Assert.IsTrue(res == 10);
        }

        [TestMethod()]
        public void arrayManipulationTest2()
        {
            ArrayManipulation am = new ArrayManipulation();
            int[][] q = new int[3][];
            q[0] = new int[] { 1, 2, 100 };
            q[1] = new int[] { 2, 5, 100 };
            q[2] = new int[] { 3, 4, 100 };
            long res = am.arrayManipulation(5, q);
            Assert.IsTrue(res == 200);
        }

        [TestMethod()]
        public void arrayManipulationTest01()
        {
            string[] lines = File.ReadAllLines(@"./array_manipulation/input01.txt");
            string[] nms = lines[0].Split(' ');
            int n = Convert.ToInt32(nms[0]);
            int m = Convert.ToInt32(nms[1]);

            ArrayManipulation am = new ArrayManipulation();
            int[][] q = new int[3][];
            for (int index = 1; index <= m; index++)
            {
                string[] data = lines[index].Split(' ');
                int[] row = new int[data.Length];
                for(int ld = 0; ld <= data.Length - 1; ld++)
                {
                    row[ld] = Convert.ToInt32(data[ld]);
                }
                q[index -1] = row;
            }
            long res = am.arrayManipulation(n, q);
            Assert.IsTrue(res == 882);
        }


    }
}