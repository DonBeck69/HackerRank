using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank.InterviewKit.Dictionary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HackerRank.InterviewKit.Dictionary.Tests
{
    [TestClass()]
    public class FrequencyTests
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

            List<int> res = fc.freqQuery3(queries);
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

            List<int> res = fc.freqQuery3(queries);
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

            List<int> res = fc.freqQuery3(queries);
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

            List<int> res = fc.freqQuery3(queries);
            Assert.IsTrue(res[0] == 0);
            Assert.IsTrue(res[1] == 1);
            Assert.IsTrue(res[2] == 1);

        }

        [TestMethod()]
        public void freqQueryTest11_1()
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

            List<int> res = fc.freqQuery2(queries);
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
        public void freqQueryTest11_2()
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

            List<int> res = fc.freqQuery2(queries);
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
        public void freqQueryTest11_3()
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

            List<int> res = fc.freqQuery3(queries);
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
        public void freqQueryTest11_4()
        {
            string[] lines = File.ReadAllLines(@"./frequency/input11.txt");
            int len = Convert.ToInt32(lines[0]);
            int[][] queries = new int[len][];
            for (int index = 1; index <= lines.Length - 1; index++)
            {

                int[] query = new int[2];

                string[] actions = lines[index].Split(' ');
                for (int vint = 0; vint <= actions.Length - 1; vint++)
                {
                    query[vint] = Convert.ToInt32(actions[vint]);
                }

                queries[index - 1] = query;
            }


            string[] outlines = File.ReadAllLines(@"./frequency/output11.txt");
            List<int> outlinesList = new List<int>();
            foreach (string ol in outlines)
            {
                outlinesList.Add(Convert.ToInt32(ol));
            }


            Frequency fc = new Frequency();

            List<int> res = fc.freqQuery4(queries);
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
        public void freqQueryTest11_5()
        {
            string[] lines = File.ReadAllLines(@"./frequency/input11.txt");
            int len = Convert.ToInt32(lines[0]);
            int[][] queries = new int[len][];
            for (int index = 1; index <= lines.Length - 1; index++)
            {

                int[] query = new int[2];

                string[] actions = lines[index].Split(' ');
                for (int vint = 0; vint <= actions.Length - 1; vint++)
                {
                    query[vint] = Convert.ToInt32(actions[vint]);
                }

                queries[index - 1] = query;
            }


            string[] outlines = File.ReadAllLines(@"./frequency/output11.txt");
            List<int> outlinesList = new List<int>();
            foreach (string ol in outlines)
            {
                outlinesList.Add(Convert.ToInt32(ol));
            }


            Frequency fc = new Frequency();

            List<int> res = fc.freqQuery5(queries);
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
        public void freqQueryTest11_6()
        {
            string[] lines = File.ReadAllLines(@"./frequency/input11.txt");
            int len = Convert.ToInt32(lines[0]);
            int[][] queries = new int[len][];
            for (int index = 1; index <= lines.Length - 1; index++)
            {

                int[] query = new int[2];

                string[] actions = lines[index].Split(' ');
                for (int vint = 0; vint <= actions.Length - 1; vint++)
                {
                    query[vint] = Convert.ToInt32(actions[vint]);
                }

                queries[index - 1] = query;
            }


            string[] outlines = File.ReadAllLines(@"./frequency/output11.txt");
            List<int> outlinesList = new List<int>();
            foreach (string ol in outlines)
            {
                outlinesList.Add(Convert.ToInt32(ol));
            }


            Frequency fc = new Frequency();

            List<int> res = fc.freqQuery5(queries);
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
        public void freqQueryTest11_7()
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

            List<int> res = fc.freqQuery7(queries);
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
