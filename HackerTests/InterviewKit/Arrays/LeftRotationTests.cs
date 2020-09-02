using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Tests
{
    [TestClass()]
    public class LeftRotationTests
    {
        [TestMethod()]
        public void rotLeftTest()
        {
            LeftRotation lr = new LeftRotation();
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            int[] result = lr.rotLeft(a, 4);
            Assert.IsTrue(string.Join(" ", result) == "5 1 2 3 4");
        }
    }
}