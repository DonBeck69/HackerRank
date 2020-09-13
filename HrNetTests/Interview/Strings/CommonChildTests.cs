using Microsoft.VisualStudio.TestTools.UnitTesting;
using HrNet.Interview.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Interview.Strings.Tests
{
    [TestClass()]
    public class CommonChildTests
    {
        [TestMethod()]
        public void commonChildTest1()
        {
            CommonChild cc = new CommonChild();

            int res = cc.commonChild("ABCD", "ABDC");

            Assert.IsTrue(res == 3);
        }

        [TestMethod()]
        public void commonChildTest2()
        {
            CommonChild cc = new CommonChild();

            int res = cc.commonChild("HARRY", "SALLY");

            Assert.IsTrue(res == 2);
        }

        [TestMethod()]
        public void commonChildTest3()
        {
            CommonChild cc = new CommonChild();

            int res = cc.commonChild("AA", "BB");

            Assert.IsTrue(res == 0);
        }

        [TestMethod()]
        public void commonChildTest4()
        {
            CommonChild cc = new CommonChild();

            int res = cc.commonChild("SHINCHAN", "NOHARAAA");

            Assert.IsTrue(res == 3);
        }

    }
}