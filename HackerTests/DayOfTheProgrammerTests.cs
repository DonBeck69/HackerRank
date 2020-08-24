using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Tests
{
    [TestClass()]
    public class DayOfTheProgrammerTests
    {
        [TestMethod()]
        public void dayOfProgrammerTest()
        {
            DayOfTheProgrammer dayOfTheProgrammer = new DayOfTheProgrammer();

            string day = dayOfTheProgrammer.dayOfProgrammer(2017);
            Assert.IsTrue(day == "13.09.2017");
        }

        [TestMethod()]
        public void dayOfProgrammerTest2()
        {
            DayOfTheProgrammer dayOfTheProgrammer = new DayOfTheProgrammer();

            string day = dayOfTheProgrammer.dayOfProgrammer(2016);
            Assert.IsTrue(day == "12.09.2016");
        }

        [TestMethod()]
        public void dayOfProgrammerTest3()
        {
            DayOfTheProgrammer dayOfTheProgrammer = new DayOfTheProgrammer();

            string day = dayOfTheProgrammer.dayOfProgrammer(1800);
            Assert.IsTrue(day == "12.09.1800");
        }

        [TestMethod()]
        public void dayOfProgrammerTest4()
        {
            DayOfTheProgrammer dayOfTheProgrammer = new DayOfTheProgrammer();

            string day = dayOfTheProgrammer.dayOfProgrammer(1804);
            Assert.IsTrue(day == "13.09.2002");
        }

        [TestMethod()]
        public void dayOfProgrammerTest5()
        {
            DayOfTheProgrammer dayOfTheProgrammer = new DayOfTheProgrammer();

            string day = dayOfTheProgrammer.dayOfProgrammer(1916);
            Assert.IsTrue(day == "12.09.1916");
        }

        [TestMethod()]
        public void dayOfProgrammerTest6()
        {
            DayOfTheProgrammer dayOfTheProgrammer = new DayOfTheProgrammer();

            string day = dayOfTheProgrammer.dayOfProgrammer(1918);
            Assert.IsTrue(day == "26.09.1918");
        }


    }
}