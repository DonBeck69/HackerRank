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
    public class ElectronicsShopTests
    {
        [TestMethod()]
        public void getMoneySpentTest1()
        {
            ElectronicsShop electronicsShop = new ElectronicsShop();
            int[] key = new int[] { 40, 50, 60 };
            int[] usb = new int[] { 5, 8, 12 };

            int res = electronicsShop.getMoneySpent(key, usb, 60);
            Assert.IsTrue(res == 58);
        }

        [TestMethod()]
        public void getMoneySpentTest2()
        {
            ElectronicsShop electronicsShop = new ElectronicsShop();
            int[] key = new int[] { 3, 1 };
            int[] usb = new int[] { 5, 2, 8 };

            int res = electronicsShop.getMoneySpent(key, usb, 10);
            Assert.IsTrue(res == 9);
        }

        [TestMethod()]
        public void getMoneySpentTest3()
        {
            ElectronicsShop electronicsShop = new ElectronicsShop();
            int[] key = new int[] { 4 };
            int[] usb = new int[] { 5 };

            int res = electronicsShop.getMoneySpent(key, usb, 5);
            Assert.IsTrue(res == -1);
        }
    }
}