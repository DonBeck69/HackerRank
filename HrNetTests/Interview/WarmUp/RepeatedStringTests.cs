using Microsoft.VisualStudio.TestTools.UnitTesting;
using HrNet.Interview.WarmUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Interview.WarmUp.Tests
{
    [TestClass()]
    public class RepeatedStringTests
    {


        [TestMethod()]
        public void repeatedStringTest1()
        {
            RepeatedString repeatedString = new RepeatedString();

            long res = repeatedString.repeatedString("abcac", 10);
            Assert.IsTrue(res == 4);
        }

        [TestMethod()]
        public void repeatedStringTest2()
        {
            RepeatedString repeatedString = new RepeatedString();

            long res = repeatedString.repeatedString("aba", 10);
            Assert.IsTrue(res == 7);
        }

        [TestMethod()]
        public void repeatedStringTest3()
        {
            RepeatedString repeatedString = new RepeatedString();

            long res = repeatedString.repeatedString("a", 1000000000000);
            Assert.IsTrue(res == 1000000000000);
        }

    }
}