using Microsoft.VisualStudio.TestTools.UnitTesting;
using HrNet.Interview.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HrNet.Interview.Strings.Tests
{
    [TestClass()]
    public class SpecialStringTests
    {
        [TestMethod()]
        public void substrCountTest()
        {
            SpecialString ss = new SpecialString();
            string s = "mnonopoo";
            long res = ss.substrCount(s.Length, s);
            Assert.IsTrue(res == 12);
        }

        [TestMethod()]
        public void substrCountTest1()
        {
            SpecialString ss = new SpecialString();
            string s = "asasd";
            long res = ss.substrCount(s.Length, s);
            Assert.IsTrue(res == 7);
        }



        [TestMethod()]
        public void substrCountTest2()
        {
            SpecialString ss = new SpecialString();
            string s = "abcbaba";
            long res = ss.substrCount(s.Length, s);
            Assert.IsTrue(res == 10);
        }

        [TestMethod()]
        public void substrCountTest3()
        {
            SpecialString ss = new SpecialString();
            string s = "aaaa";
            long res = ss.substrCount(s.Length, s);
            Assert.IsTrue(res == 10);
        }


        [TestMethod()]
        public void substrCountTest4()
        {
            SpecialString ss = new SpecialString();
            string s = "aabaa";
            long res = ss.substrCount(s.Length, s);
            Assert.IsTrue(res == 9);
        }


        [TestMethod()]
        public void substrCountTest5()
        {
            SpecialString ss = new SpecialString();
            string s = "aabaa";
            long res = ss.substrCount(s.Length, s);
            Assert.IsTrue(res == 9);
        }




        [TestMethod()]
        public void substrCountTest6()
        {
            SpecialString ss = new SpecialString();
            string s = "aaabaaca";
            long res = ss.substrCount(s.Length, s);
            Assert.IsTrue(res == 15);
        }



        [TestMethod()]
        public void substrCountTest02()
        {
            string[] lines = File.ReadAllLines(@"./special_string/input02.txt");
            string s = lines[1];

            SpecialString ss = new SpecialString();
            //string s = "aaabaaca";
            long res = ss.substrCount(s.Length, s);
            Assert.IsTrue(res == 1272919);
        }

        [TestMethod()]
        public void substrCountTest02_2()
        {
            string[] lines = File.ReadAllLines(@"./special_string/input02.txt");
            string s = lines[1];

            SpecialString ss = new SpecialString();
            //string s = "aaabaaca";
            long res = ss.stolen(s.Length, s);
            Assert.IsTrue(res == 1272919);
        }



    }
}