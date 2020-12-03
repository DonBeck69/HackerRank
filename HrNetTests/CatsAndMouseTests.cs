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
    public class CatsAndMouseTests
    {
        [TestMethod()]
        public void catAndMouseTest1()
        {
            CatsAndMouse catsAndMouse = new CatsAndMouse();
            string res = catsAndMouse.catAndMouse(1, 2, 3);
            Assert.IsTrue(res == "Cat B");
        }

        [TestMethod()]
        public void catAndMouseTest2()
        {
            CatsAndMouse catsAndMouse = new CatsAndMouse();
            string res = catsAndMouse.catAndMouse(1, 3, 2);
            Assert.IsTrue(res == "Mouse C");
        }

        [TestMethod()]
        public void catAndMouseTest3()
        {
            CatsAndMouse catsAndMouse = new CatsAndMouse();
            string res = catsAndMouse.catAndMouse(1, 6, 2);
            Assert.IsTrue(res == "Cat A");
        }
    }
}