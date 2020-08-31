using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.InterviewKit.Dictionary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using HackerRank;

namespace HackerRank.InterviewKit.Dictionary.Tests
{
    [TestClass()]
    public class RansomNoteTests
    {
        [TestMethod()]
        public void checkMagazineTest()
        {
            RansomNote rn = new RansomNote();
            string[] mag = "give me one grand today night".Split(' ');
            string[] note = "give one grand today".Split(' ');

            string res = rn.checkMagazine(mag, note);
            Assert.IsTrue(res == "Yes");
        }

        [TestMethod()]
        public void checkMagazineTest2()
        {
            RansomNote rn = new RansomNote();
            string[] mag = "two times three is not four".Split(' ');
            string[] note = "two times two is four".Split(' ');

            string res = rn.checkMagazine(mag, note);
            Assert.IsTrue(res == "No");
        }

        [TestMethod()]
        public void checkMagazineTest3()
        {
            RansomNote rn = new RansomNote();
            string[] mag = "ive got some lovely bunch of coconuts".Split(' ');
            string[] note = "ive got some Coconuts".Split(' ');

            string res = rn.checkMagazine(mag, note);
            Assert.IsTrue(res == "No");
        }

        [TestMethod()]
        public void checkMagazineTest10()
        {
            string[] lines = File.ReadAllLines(@"./Ransom/input10.txt");
            string[] mag = lines[1].Split(' ');
            string[] note = lines[2].Split(' ');

            RansomNote rn = new RansomNote();
            string res = rn.checkMagazine(mag, note);
            Assert.IsTrue(res == "No");
        }


    }
}