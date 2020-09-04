using Microsoft.VisualStudio.TestTools.UnitTesting;
using HrNet.Interview.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Interview.Sorting.Tests
{
    [TestClass()]
    public class MarkAndToysTests
    {
        [TestMethod()]
        public void maximumToysTest()
        {
            MarkAndToys mt = new MarkAndToys();
            int res = mt.maximumToys(new int[] { 1, 12, 5, 111, 200, 1000, 10 }, 50);
            Assert.IsTrue(res == 4);
        }
    }
}