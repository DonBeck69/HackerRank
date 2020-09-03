using Microsoft.VisualStudio.TestTools.UnitTesting;
using HrNet.InterviewKit.Dictionary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace HrNet.InterviewKit.Dictionary.Tests
{
    [TestClass]
    public class HrNetTest
    {
        [TestMethod()]
        public void freqQueryTest1()
        {
            string[] lines = File.ReadAllLines(@"./frequency/1.txt");
            List<int[]> queries = new List<int[]>();
            for (int index = 1; index <= lines.Length - 1; index++)
            {

                int[] query = new int[2];

                string[] actions = lines[index].Split(' ');
                for (int vint = 0; vint <= actions.Length - 1; vint++)
                {
                    query[vint] = Convert.ToInt32(actions[vint]);
                }

                queries.Add(query);
            }

            
            Frequency fc = new Frequency();

            List<int> res = fc.freqQuery(queries);
            Assert.IsTrue(res[0] == 0);
            Assert.IsTrue(res[1] == 1);

        }

        [TestMethod()]
        public void freqQueryTest2()
        {
            string[] lines = File.ReadAllLines(@"./frequency/2.txt");
            List<int[]> queries = new List<int[]>();
            for (int index = 1; index <= lines.Length - 1; index++)
            {

                int[] query = new int[2];

                string[] actions = lines[index].Split(' ');
                for (int vint = 0; vint <= actions.Length - 1; vint++)
                {
                    query[vint] = Convert.ToInt32(actions[vint]);
                }

                queries.Add(query);
            }


            Frequency fc = new Frequency();

            List<int> res = fc.freqQuery(queries);
            Assert.IsTrue(res[0] == 0);
            Assert.IsTrue(res[1] == 1);

        }


        [TestMethod()]
        public void freqQueryTest3()
        {
            string[] lines = File.ReadAllLines(@"./frequency/3.txt");
            List<int[]> queries = new List<int[]>();
            for (int index = 1; index <= lines.Length - 1; index++)
            {

                int[] query = new int[2];

                string[] actions = lines[index].Split(' ');
                for (int vint = 0; vint <= actions.Length - 1; vint++)
                {
                    query[vint] = Convert.ToInt32(actions[vint]);
                }

                queries.Add(query);
            }


            Frequency fc = new Frequency();

            List<int> res = fc.freqQuery(queries);
            Assert.IsTrue(res[0] == 0);
            Assert.IsTrue(res[1] == 1);

        }

        [TestMethod()]
        public void freqQueryTest4()
        {
            string[] lines = File.ReadAllLines(@"./frequency/4.txt");
            List<int[]> queries = new List<int[]>();
            for (int index = 1; index <= lines.Length - 1; index++)
            {

                int[] query = new int[2];

                string[] actions = lines[index].Split(' ');
                for (int vint = 0; vint <= actions.Length - 1; vint++)
                {
                    query[vint] = Convert.ToInt32(actions[vint]);
                }

                queries.Add(query);
            }


            Frequency fc = new Frequency();

            List<int> res = fc.freqQuery(queries);
            Assert.IsTrue(res[0] == 0);
            Assert.IsTrue(res[1] == 1);
            Assert.IsTrue(res[2] == 1);

        }

        [TestMethod()]
        public void freqQueryTest05()
        {
            string[] lines = File.ReadAllLines(@"./frequency/input05.txt");
            string[] outlines = File.ReadAllLines(@"./frequency/output05.txt");
            List<int[]> queries = new List<int[]>();
            for (int index = 1; index <= lines.Length - 1; index++)
            {

                int[] query = new int[2];

                string[] actions = lines[index].Split(' ');
                for (int vint = 0; vint <= actions.Length - 1; vint++)
                {
                    query[vint] = Convert.ToInt32(actions[vint]);
                }

                queries.Add(query);
            }

            List<int> outlinesList = new List<int>();
            foreach (string ol in outlines)
            {
                outlinesList.Add(Convert.ToInt32(ol));
            }


            Frequency fc = new Frequency();
            List<int> res = fc.freqQuery(queries, outlinesList);

            bool check = true;
            for (int index = 0; index <= res.Count - 1; index++)
            {
                if (res[index] != outlinesList[index])
                {
                    check = false;
                }
            }
            Assert.IsTrue(check);

        }



        [TestMethod()]
        public void freqQueryTest11()
        {
            string[] lines = File.ReadAllLines(@"./frequency/input11.txt");
            string[] outlines = File.ReadAllLines(@"./frequency/output11.txt");
            List<int[]> queries = new List<int[]>();
            for (int index = 1; index <= lines.Length - 1; index++)
            {

                int[] query = new int[2];

                string[] actions = lines[index].Split(' ');
                for (int vint = 0; vint <= actions.Length - 1; vint++)
                {
                    query[vint] = Convert.ToInt32(actions[vint]);
                }

                queries.Add(query);
            }

            List<int> outlinesList = new List<int>();
            foreach (string ol in outlines)
            {
                outlinesList.Add(Convert.ToInt32(ol));
            }


            Frequency fc = new Frequency();
            List<int> res = fc.freqQuery(queries);
            bool check = true;
            for (int index = 0; index <= res.Count - 1; index++)
            {
                if (res[index] != outlinesList[index])
                {
                    check = false;
                }
            }
            Assert.IsTrue(check);

        }

    }
}

