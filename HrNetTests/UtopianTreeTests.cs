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
    public class UtopianTreeTests
    {
        [TestMethod()]
        public void utopianTreeTest()
        {
            UtopianTree utopianTree = new UtopianTree();
            int res = utopianTree.utopianTree(5);
            Assert.IsTrue(res == 14);
        }

        [TestMethod()]
        public void utopianTreeTest2()
        {
            UtopianTree utopianTree = new UtopianTree();
            int res = utopianTree.utopianTree(0);
            Assert.IsTrue(res == 1);

            res = utopianTree.utopianTree(1);
            Assert.IsTrue(res == 2);

            res = utopianTree.utopianTree(4);
            Assert.IsTrue(res == 7);
        }
    }
}