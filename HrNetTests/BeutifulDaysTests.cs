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
    public class BeutifulDaysTests
    {

        //test the reverse function
        [TestMethod()]
        public void ReverseIntTest()
        {
            BeautifulDays beautifulDays = new BeautifulDays();
            int res = beautifulDays.ReverseInt(1234);
            Assert.IsTrue(res == 4321);
        }

        [TestMethod()]
        public void ReverseIntTest1()
        {
            BeautifulDays beautifulDays = new BeautifulDays();
            int res = beautifulDays.ReverseInt(1230);
            Assert.IsTrue(res == 321);
        }

        [TestMethod()]
        public void ReverseIntTest2()
        {
            BeautifulDays beautifulDays = new BeautifulDays();
            int res = beautifulDays.ReverseInt(1003);
            Assert.IsTrue(res == 3001);
        }

        //test the beautifill days function
        [TestMethod()]
        public void beautifulDaysTest1()
        {
            BeautifulDays beautifulDays = new BeautifulDays();
            int res = beautifulDays.beautifulDays(20, 23, 6);
            Assert.IsTrue(res == 2);
        }
    }
}