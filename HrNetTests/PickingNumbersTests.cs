using Microsoft.VisualStudio.TestTools.UnitTesting;
using HrNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Tests
{
    [TestClass()]
    public class PickingNumbersTests
    {
        [TestMethod()]
        public void pickingNumbersTest1()
        {
            PickingNumbers pickingNumbers = new PickingNumbers();
            List<int> a = new List<int>() { 1, 1, 2, 2, 4, 4, 5, 5, 5 };
            int res = pickingNumbers.pickingNumbers(a);
            Assert.IsTrue(res == 5);
        }

        [TestMethod()]
        public void pickingNumbersTest2()
        {
            PickingNumbers pickingNumbers = new PickingNumbers();
            List<int> a = new List<int>() { 4, 6, 5, 3, 3, 1 };
            int res = pickingNumbers.pickingNumbers(a);
            Assert.IsTrue(res == 3);
        }

        [TestMethod()]
        public void pickingNumbersTest3()
        {
            PickingNumbers pickingNumbers = new PickingNumbers();
            List<int> a = new List<int>() { 1, 2, 2, 3, 1, 2 };
            int res = pickingNumbers.pickingNumbers(a);
            Assert.IsTrue(res == 5);
        }
    }
}