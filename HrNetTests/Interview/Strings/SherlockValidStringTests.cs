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
    public class SherlockValidStringTests
    {
        [TestMethod()]
        public void isValidTest1()
        {
            SherlockValidString svs = new SherlockValidString();
            string res = svs.isValid("aabbcd");
            Assert.IsTrue(res == "NO");
        }

        [TestMethod()]
        public void isValidTest2()
        {
            SherlockValidString svs = new SherlockValidString();
            string res = svs.isValid("aabbccddeefghi");
            Assert.IsTrue(res == "NO");
        }


        [TestMethod()]
        public void isValidTest3()
        {
            SherlockValidString svs = new SherlockValidString();
            string res = svs.isValid("abcdefghhgfedecba");
            Assert.IsTrue(res == "YES");
        }

        [TestMethod()]
        public void isValidTestA()
        {
            SherlockValidString svs = new SherlockValidString();
            string res = svs.isValid("aaaa");
            Assert.IsTrue(res == "YES");
        }

        [TestMethod()]
        public void isValidTest03()
        {
            SherlockValidString svs = new SherlockValidString();
            string res = svs.isValid("aaaabbcc");
            Assert.IsTrue(res == "NO");
        }

        [TestMethod()]
        public void isValidTest05()
        {
            SherlockValidString svs = new SherlockValidString();
            string res = svs.isValid("aaaaabc");
            Assert.IsTrue(res == "NO");
        }


        [TestMethod()]
        public void isValidTest07()
        {
            string[] lines = File.ReadAllLines(@"./sherlock/input07.txt");
            string s = lines[0];
            SherlockValidString svs = new SherlockValidString();
            string res = svs.isValid(s);
            Assert.IsTrue(res == "YES");
        }



    }
}