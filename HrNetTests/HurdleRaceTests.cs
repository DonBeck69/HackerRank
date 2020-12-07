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
    public class HurdleRaceTests
    {
        [TestMethod()]
        public void hurdleRaceTest1()
        {
            HurdleRace hurdleRace = new HurdleRace();
            int res = hurdleRace.hurdleRace(1, new int[] { 1, 2, 3, 3, 2 });
            Assert.IsTrue(res == 2);
        }

        [TestMethod()]
        public void hurdleRaceTest2()
        {
            HurdleRace hurdleRace = new HurdleRace();
            int res = hurdleRace.hurdleRace(4, new int[] { 1, 6, 3, 5, 2 });
            Assert.IsTrue(res == 2);
        }

        [TestMethod()]
        public void hurdleRaceTest3()
        {
            HurdleRace hurdleRace = new HurdleRace();
            int res = hurdleRace.hurdleRace(7, new int[] { 2, 5, 4, 5, 2 });
            Assert.IsTrue(res == 0);
        }
    }
}