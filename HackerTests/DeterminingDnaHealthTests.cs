using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRank;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

using HackerRank.AhoCorasick;


namespace HackerRank.Tests
{
    [TestClass()]
    public class DeterminingDnaHealthTests
    {

        [TestMethod()]
        public void AhoCorasickTest0()
        {
            FunctionData functionData = GetFunctionData(@"./DnaData/input01.txt");

            string text = functionData.GeneDataList[0].Sequence;// "hello, hello and welcome to this beautiful world!";

            Trie trie = new Trie();

            trie.Add(functionData.Genes);
            trie.Build();

            string[] matches = trie.Find(text).ToArray();

            Assert.AreEqual(2, matches.Length);
            Assert.AreEqual("hello", matches[0]);
            Assert.AreEqual("world", matches[1]);

        }


        [TestMethod()]
        public void AhoCorasickTest2()
        {
            //FunctionData functionData = GetFunctionData(@"./DnaData/input01.txt");

            string text = "world, i hello you!";
            string[] words = new[] { "hello", "world" };


            Trie<int> trie = new Trie<int>();
            for (int i = 0; i < words.Length; i++)
                trie.Add(words[i], i);
            trie.Build();

            int[] lines = trie.Find(text).ToArray();

            Assert.AreEqual(2, lines.Length);
            Assert.AreEqual(1, lines[0]);
            Assert.AreEqual(0, lines[1]);

        }


        [TestMethod()]
        public void GetHealthTest()
        {
            FunctionData functionData = new FunctionData()
            {
                GeneCount = 6,
                Genes = new string[] { "a", "b", "c", "aa", "d", "b" },
                Health = new int[] { 1, 2, 3, 4, 5, 6 }
            };

            
            for (int index = 0; index <= functionData.Health.Length - 1; index++)
            {
                if (functionData.GenesHealth.ContainsKey(functionData.Genes[index]))
                {
                    functionData.GenesHealth[functionData.Genes[index]].Add(index, functionData.Health[index]);
                }
                else
                {
                    Dictionary<int, int> scores = new Dictionary<int, int>();
                    scores.Add(index, Convert.ToInt32(functionData.Health[index]));
                    functionData.GenesHealth.Add(functionData.Genes[index], scores);
                }
                //health[index] = Convert.ToInt32(healths[index]);
            }
            

            GeneData geneData1 = new GeneData()
            {
                First = 1,
                Last = 5,
                Sequence = "caaab"
            };

            GeneData geneData2 = new GeneData()
            {
                First = 0,
                Last = 4,
                Sequence = "xyz"
            };
            GeneData geneData3 = new GeneData()
            {
                First = 2,
                Last = 4,
                Sequence = "bcdybc"
            };

            functionData.GeneDataList.Add(geneData1);
            functionData.GeneDataList.Add(geneData2);
            functionData.GeneDataList.Add(geneData3);

            functionData.MinFirst = 0;
            functionData.MaxLast = 5;


            DeterminingDnaHealth determiningDnaHealth = new DeterminingDnaHealth();

            long[] result = determiningDnaHealth.GetHealth(functionData);

            Assert.IsTrue($"{result[0]} {result[1]}" == "0 19");

        }


        [TestMethod()]
        public void GetHealthTest1()
        {
            FunctionData functionData = GetFunctionData(@"./DnaData/input01.txt");




            DeterminingDnaHealth determiningDnaHealth = new DeterminingDnaHealth();
            long[] result = determiningDnaHealth.GetHealth(functionData);
            Console.WriteLine($"Min: {result[0]}");
            Console.WriteLine($"Max: {result[1]}");
            Assert.IsTrue($"{result[0]} {result[1]}" == "3218660 11137051");

        }

        [TestMethod()]
        public void GetHealthTest1_AC()
        {

            FunctionData functionData = GetFunctionData(@"./DnaData/input01.txt");

            DeterminingDnaHealth determiningDnaHealth = new DeterminingDnaHealth();

            long[] result = determiningDnaHealth.GetHealthAC(functionData);

            Console.WriteLine($"Min: {result[0]}");
            Console.WriteLine($"Max: {result[1]}");
            Assert.IsTrue($"{result[0]} {result[1]}" == "15806635 20688978289");

        }


        [TestMethod()]
        public void GetHealthTest2()
        {

            FunctionData functionData = GetFunctionData(@"./DnaData/input02.txt");

            DeterminingDnaHealth determiningDnaHealth = new DeterminingDnaHealth();

            long[] result = determiningDnaHealth.GetHealth(functionData);

            Console.WriteLine($"Min: {result[0]}");
            Console.WriteLine($"Max: {result[1]}");
            Assert.IsTrue($"{result[0]} {result[1]}" == "15806635 20688978289");

        }



        [TestMethod()]
        public void GetHealthTest2_AC()
        {

            FunctionData functionData = GetFunctionData(@"./DnaData/input02.txt");

            DeterminingDnaHealth determiningDnaHealth = new DeterminingDnaHealth();

            long[] result = determiningDnaHealth.GetHealthAC(functionData);

            Console.WriteLine($"Min: {result[0]}");
            Console.WriteLine($"Max: {result[1]}");
            Assert.IsTrue($"{result[0]} {result[1]}" == "15806635 20688978289");

        }


        public FunctionData GetFunctionData(string TestDataFile)
        {
            string[] lines = File.ReadAllLines(TestDataFile); // triangle1 // triangle2
            FunctionData functionData = new FunctionData();
            int geneCount = Convert.ToInt32(lines[0]);
            functionData.GeneCount = geneCount;
            string[] genes = lines[1].Split(' ');
            string[] healths = lines[2].Split(' ');
            int[] health = new int[geneCount];



            for (int index = 0; index <= genes.Length - 1; index++)
            {
                health[index] = Convert.ToInt32(healths[index]);

                if (functionData.GenesHealth.ContainsKey(genes[index]))
                {
                    functionData.GenesHealth[genes[index]].Add(index, health[index]);
                }
                else
                {
                    Dictionary<int, int> scores = new Dictionary<int, int>();
                    scores.Add(index, Convert.ToInt32(healths[index]));
                    functionData.GenesHealth.Add(genes[index], scores);
                }
            }

            functionData.Health = health;
            functionData.Genes = genes;


            //int sequenceCount = Convert.ToInt32(lines[3]) + 4;

            for (int count = 4; count <= lines.Length - 1; count++)
            {
                string seqLine = lines[count];
                string[] seqData = seqLine.Split(' ');
                int first = Convert.ToInt32(seqData[0]);
                int last = Convert.ToInt32(seqData[1]);
                string seq = seqData[2];

                GeneData geneData = new GeneData()
                {
                    First = first,
                    Last = last,
                    Sequence = seq
                };

                functionData.GeneDataList.Add(geneData);

            }

            return functionData;
        }
    }
}