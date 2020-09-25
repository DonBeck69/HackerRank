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
    public class JumpingCloudsTests
    {
        [TestMethod()]
        public void jumpingOnCloudsTest()
        {
            JumpingClouds jc = new JumpingClouds();
            int res = jc.jumpingOnClouds(new int[] { 0, 1, 0, 0, 0, 1, 0 });
            Assert.IsTrue(res == 3);
        }

        [TestMethod()]
        public void jumpingOnCloudsTest2()
        {
            JumpingClouds jc = new JumpingClouds();
            int res = jc.jumpingOnClouds(new int[] { 0, 0, 1, 0, 0, 1, 0 });
            Assert.IsTrue(res == 4);
        }

        [TestMethod()]
        public void jumpingOnCloudsTest3()
        {
            JumpingClouds jc = new JumpingClouds();
            int res = jc.jumpingOnClouds(new int[] { 0, 0, 0, 0, 1, 0 });
            Assert.IsTrue(res == 3);
        }

        [TestMethod()]
        public void jumpingOnCloudsTest4()
        {
            JumpingClouds jc = new JumpingClouds();
            int res = jc.jumpingOnClouds(new int[] { 0, 0, 1, 0, 0, 0, 0 });
            Assert.IsTrue(res == 4);
        }



    }
}