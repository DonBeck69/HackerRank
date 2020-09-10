using Microsoft.VisualStudio.TestTools.UnitTesting;
using HrNet.Interview.Sorting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Interview.Sorting.Tests
{
    [TestClass()]
    public class CountingInversionsTests
    {

        [TestMethod()]
        public void countInversionsTest1()
        {
            CountingInversions ci = new CountingInversions();
            long count = ci.countInversions(new int[] { 1, 1, 1, 2, 2 });
            Assert.IsTrue(count == 0);
        }

        [TestMethod()]
        public void countInversionsTest2()
        {
            CountingInversions ci = new CountingInversions();
            long count = ci.countInversions(new int[] { 2, 1, 3, 1, 2 });
            Assert.IsTrue(count == 4);
        }
        [TestMethod()]
        public void countInversionsTest3()
        {
            CountingInversions ci = new CountingInversions();
            long count = ci.countInversions(new int[] { 1, 5, 3, 7 });
            Assert.IsTrue(count == 1);
        }
        [TestMethod()]
        public void countInversionsTest4()
        {
            CountingInversions ci = new CountingInversions();
            long count = ci.countInversions(new int[] { 7, 5, 3, 1 });
            Assert.IsTrue(count == 6);
        }

        [TestMethod()]
        public void countInversionsTest5()
        {
            CountingInversions ci = new CountingInversions();
            long count = ci.countInversions(new int[] { 1, 3, 5, 7 });
            Assert.IsTrue(count == 0);
        }
        [TestMethod()]
        public void countInversionsTest6()
        {
            CountingInversions ci = new CountingInversions();
            long count = ci.countInversions(new int[] { 3, 2, 1 });
            Assert.IsTrue(count == 3);
        }




        [TestMethod()]
        public void countInversionsTest13()
        {
            CountingInversions ci = new CountingInversions();
            string[] lines = File.ReadAllLines(@"./mergesort/input13.txt");
            string[] outLines = File.ReadAllLines(@"./mergesort/output13.txt");
            int tests = Convert.ToInt32(lines[0]);
            int lineCount = 1;
            long result = 0;
            for (int sets = 0; sets <= tests - 1; sets++)
            {
                int count = Convert.ToInt32(lines[lineCount++]);
                result = Convert.ToInt64(outLines[sets]);
                string[] stringData = lines[lineCount++].Split(' ');
                int[] data = new int[count];
                for (int i = 0; i <= data.Length - 1; i++)
                {
                    data[i] = Convert.ToInt32(stringData[i]);
                }

                long swaps = ci.countInversions(data);
                Assert.IsTrue(swaps == result);

            }
        }


    }
}