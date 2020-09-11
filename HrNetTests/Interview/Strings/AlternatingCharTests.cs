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
    public class AlternatingCharTests
    {
        [TestMethod()]
        public void alternatingCharactersTest1()
        {
            AlternatingChar ac = new AlternatingChar();
            int res = ac.alternatingCharacters("AABAAB");
            Assert.IsTrue(res == 2);
        }

        [TestMethod()]
        public void alternatingCharactersTest2()
        {
            AlternatingChar ac = new AlternatingChar();
            int res = ac.alternatingCharacters("AAAA");
            Assert.IsTrue(res == 3);
            res = ac.alternatingCharacters("BBBBB");
            Assert.IsTrue(res == 4);
            res = ac.alternatingCharacters("ABABABAB");
            Assert.IsTrue(res == 0);
            res = ac.alternatingCharacters("BABABA");
            Assert.IsTrue(res == 0);
            res = ac.alternatingCharacters("AAABBB");
            Assert.IsTrue(res == 4);
        }

    }
}