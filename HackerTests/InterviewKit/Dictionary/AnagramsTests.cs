using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using HackerRank.InterviewKit.Dictionary;

namespace HackerRank.InterviewKit.Dictionary.Tests
{ 
    [TestClass()]
    public class AnagramsTests
    {
        [TestMethod()]
        public void sherlockAndAnagramsTest1()
        {
            Anagrams an = new Anagrams();
            int res = an.sherlockAndAnagrams("abba");
            Assert.IsTrue(res == 4);
        }

        [TestMethod()]
        public void sherlockAndAnagramsTest2()
        {
            Anagrams an = new Anagrams();
            int res = an.sherlockAndAnagrams("abcd");
            Assert.IsTrue(res == 0);
        }

        [TestMethod()]
        public void sherlockAndAnagramsTest3()
        {
            Anagrams an = new Anagrams();
            int res = an.sherlockAndAnagrams("ifailuhkqq");
            Assert.IsTrue(res == 3);
        }
        [TestMethod()]
        public void sherlockAndAnagramsTest4()
        {
            Anagrams an = new Anagrams();
            int res = an.sherlockAndAnagrams("kkkk");
            Assert.IsTrue(res == 10);
        }
        [TestMethod()]
        public void sherlockAndAnagramsTest5()
        {
            Anagrams an = new Anagrams();
            int res = an.sherlockAndAnagrams("cdcd");
            Assert.IsTrue(res == 5);
        }

        [TestMethod()]
        public void sherlockAndAnagramsTest6()
        {
            Anagrams an = new Anagrams();
            int res = an.sherlockAndAnagrams("aaaaaa");
            Assert.IsTrue(res == 35);
        }



    }
}