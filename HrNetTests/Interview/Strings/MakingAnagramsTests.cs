using Microsoft.VisualStudio.TestTools.UnitTesting;
using HrNet.Interview.Strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Interview.Strings.Tests
{
    [TestClass()]
    public class MakingAnagramsTests
    {
        [TestMethod()]
        public void makeAnagramTest0()
        {
            MakingAnagrams ma = new MakingAnagrams();
            int res = ma.makeAnagram("cde", "abc");
            Assert.IsTrue(res == 4);
        }

        [TestMethod()]
        public void makeAnagramTest2()
        {
            MakingAnagrams ma = new MakingAnagrams();
            int res = ma.makeAnagram("showman", "woman");
            Assert.IsTrue(res == 2);
        }
        [TestMethod()]
        public void makeAnagramTest1()
        {
            MakingAnagrams ma = new MakingAnagrams();
            int res = ma.makeAnagram("fcrxzwscanmligyxyvym", "jxwtrhvujlmrpdoqbisbwhmgpmeoke");
            Assert.IsTrue(res == 30);
        }

    }
}