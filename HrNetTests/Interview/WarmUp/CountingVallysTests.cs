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
    public class CountingVallysTests
    {
        [TestMethod()]
        public void countingValleysTest()
        {
            CountingVallys cv = new CountingVallys();
            int res = cv.countingValleys(8, "DDUUUUDD");
            Assert.IsTrue(res == 1);
        }
        [TestMethod()]
        public void countingValleysTest2()
        {
            CountingVallys cv = new CountingVallys();
            int res = cv.countingValleys(8, "UDDDUDUU");
            Assert.IsTrue(res == 1);
        }
    }
}