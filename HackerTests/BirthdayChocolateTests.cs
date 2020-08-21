using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank;


namespace HackerTests
{
    [TestClass]
    public class BirthdayChocolateTests
    {
        [TestMethod]
        public void one()
        {
            BirthdayChocolate theThing = new BirthdayChocolate();
            int records = theThing.birthday(new List<int> { 1, 2, 1, 3, 2 }, 3, 2);

            Assert.IsTrue(records == 2);
        }

    }
}
