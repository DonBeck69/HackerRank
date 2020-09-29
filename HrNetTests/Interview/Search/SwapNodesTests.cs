using Microsoft.VisualStudio.TestTools.UnitTesting;
using HrNet.Interview.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Interview.Search.Tests
{
    [TestClass()]
    public class SwapNodesTests
    {
        [TestMethod()]
        public void swapNodesTest0()
        {
            SwapNodes swapNodes = new SwapNodes();
            int[][] indexes = new int[3][];
            indexes[0] = new int[2] { 2, 3 };
            indexes[1] = new int[2] { -1, -1 };
            indexes[2] = new int[2] { -1, -1 };
            int[] qs = new int[2] { 1, 1 };
            int[][] res = swapNodes.swapNodes(indexes, qs);

            Assert.IsTrue(string.Join(",", res[0]) == "3,1,2");
            Assert.IsTrue(string.Join(",", res[1]) == "2,1,3");
        }


        [TestMethod()]
        public void swapNodesTest1()
        {
            SwapNodes swapNodes = new SwapNodes();
            int[][] indexes = new int[5][];
            indexes[0] = new int[2] { 2, 3 };
            indexes[1] = new int[2] { -1, 4 };
            indexes[2] = new int[2] { -1, 5 };
            indexes[3] = new int[2] { -1, -1 };
            indexes[4] = new int[2] { -1, -1 };
            int[] qs = new int[1] { 2 };
            int[][] res = swapNodes.swapNodes(indexes, qs);

            Assert.IsTrue(string.Join(",", res[0]) == "4,2,1,5,3");
            //Assert.IsTrue(string.Join(",", res[1]) == "2,1,3");
        }


        [TestMethod()]
        public void swapNodesTest2()
        {
            SwapNodes swapNodes = new SwapNodes();
            int[][] indexes = new int[11][];
            indexes[0] = new int[2] { 2, 3 };
            indexes[1] = new int[2] { 4, -1 };
            indexes[2] = new int[2] { 5, -1 };
            indexes[3] = new int[2] { 6, -1 };
            indexes[4] = new int[2] { 7, 8 };
            indexes[5] = new int[2] { -1, 9 };
            indexes[6] = new int[2] { -1, -1 };
            indexes[7] = new int[2] { 10, 11};
            indexes[8] = new int[2] { -1, -1 };
            indexes[9] = new int[2] { -1, -1 };
            indexes[10] = new int[2] { -1, -1 };
            int[] qs = new int[2] { 2, 4 };
            int[][] res = swapNodes.swapNodes(indexes, qs);

            Assert.IsTrue(string.Join(", ", res[0]) == "2, 9, 6, 4, 1, 3, 7, 5, 11, 8, 10");
            Assert.IsTrue(string.Join(", ", res[1]) == "2, 6, 9, 4, 1, 3, 7, 5, 10, 8, 11");
        }

    }
}