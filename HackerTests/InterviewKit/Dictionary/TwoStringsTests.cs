using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.InterviewKit.Dictionary;
using System;
using System.Collections.Generic;
using System.Text;
using HackerRank;

namespace HackerRank.InterviewKit.Dictionary.Tests
{
    [TestClass()]
    public class TwoStringsTests
    {
        [TestMethod()]
        public void twoStringsTest()
        {
            TwoStrings ts = new TwoStrings();
            string s1 = "hello";
            string s2 = "world";
            string result = ts.twoStrings(s1, s2);

            Assert.IsTrue(result == "YES");
        }
    }
}