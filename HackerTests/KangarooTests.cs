using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Tests
{
    [TestClass()]
    public class KangarooTests
    {
        [TestMethod()]
        public void kangaroo1Test()
        {
            Kangaroo k = new Kangaroo();
            string result = k.kangaroo(0, 3, 4, 2);
            Assert.IsTrue(result == "YES");

        }

        [TestMethod()]
        public void kangaroo2Test()
        {
            Kangaroo k = new Kangaroo();
            string result = k.kangaroo(0, 2, 5, 3);
            Assert.IsTrue(result == "NO");

        }

        [TestMethod()]
        public void kangaroo3Test()
        {
            Kangaroo k = new Kangaroo();
            string result = k.kangaroo(43, 2, 70, 2);
            Assert.IsTrue(result == "NO");

        }

    }
}