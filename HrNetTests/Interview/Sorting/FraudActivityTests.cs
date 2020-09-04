using Microsoft.VisualStudio.TestTools.UnitTesting;
using HrNet.Interview.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HrNet.Interview.Sorting.Tests
{
    [TestClass()]
    public class FraudActivityTests
    {




        [TestMethod()]
        public void activityNotificationsTest1()
        {
            FraudActivity fa = new FraudActivity();
            int note = fa.activityNotifications(new double[] { 10, 20, 30, 40, 50 }, 3);
            Assert.IsTrue(note == 1);
        }




        [TestMethod()]
        public void activityNotificationsTest2()
        {
            FraudActivity fa = new FraudActivity();
            int note = fa.activityNotifications(new double[] { 2, 3, 4, 2, 3, 6, 8, 4, 5 }, 5);
            Assert.IsTrue(note == 2);
        }


        [TestMethod()]
        public void activityNotificationsTest2_1()
        {
            FraudActivity fa = new FraudActivity();
            int note = fa.activityNotifications(new double[] { 2, 3, 4, 2, 3, 6, 8, 4, 5 }, 4);
            Assert.IsTrue(note == 2);
        }



        [TestMethod()]
        public void activityNotificationsTest01()
        {
            string[] lines = File.ReadAllLines(@"./fraud/input01.txt");
            string[] datas = lines[0].Split(' ');
            int len = Convert.ToInt32(datas[0]);
            int days = Convert.ToInt32(datas[1]);
            string[] exps = lines[1].Split(' ');
            double[] expen = new double[len];
            expen = Array.ConvertAll(exps, a => Convert.ToDouble(a));
            //expen = expen.Take(2000).ToArray();

            FraudActivity fa = new FraudActivity();
            int note = fa.activityNotifications(expen, days);
            Assert.IsTrue(note == 633);
        }



    }
}