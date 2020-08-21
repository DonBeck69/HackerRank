using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank;

namespace HackerTests
{
    [TestClass]
    public class BetweenNumbersTest
    {
        [TestMethod]
        public void BTone()
        {
            BetweenTwoSetsFactors bf = new BetweenTwoSetsFactors();
            List<int> a = new List<int> { 3, 9, 6 };
            List<int> b = new List<int> { 36, 72 };
            List<int> result = bf.getBetweenNumbers(a, b);
            foreach (int bn in result)
            {
                Console.WriteLine(bn);
            }
            Console.WriteLine(result.Count);
            Assert.IsTrue(result.Count == 2);
        }
    }
}
