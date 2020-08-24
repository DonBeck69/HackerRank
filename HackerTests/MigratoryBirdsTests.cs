using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Tests
{
    [TestClass()]
    public class MigratoryBirdsTests
    {

        [TestMethod()]
        public void migratoryBirds1Test()
        {
            MigratoryBirds theClass = new MigratoryBirds();

            List<int> birds = new List<int> { 1, 4, 4, 4, 5, 3 };
            int score = theClass.migratoryBirds(birds);

            Assert.IsTrue(score == 4);
        }

        [TestMethod()]
        public void migratoryBirds2Test()
        {
            MigratoryBirds theClass = new MigratoryBirds();

            List<int> birds = new List<int> { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4, };
            int score = theClass.migratoryBirds(birds);

            Assert.IsTrue(score == 3);
        }
    }
}