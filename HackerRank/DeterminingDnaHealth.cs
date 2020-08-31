using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using HackerRank.AhoCorasick;

namespace HackerRank
{
    public class DeterminingDnaHealth
    {
        //int GeneCount, string[] Genes, int[] Health, string[] FirstLast, int Start, int End
        public long[] GetHealth(FunctionData Data)
        {
            long[] result = new long[2];
            long[] sequenceScores = new long[Data.GeneDataList.Count];
            // loop the sequences
            //for (int genx = 0; genx <= Data.GeneDataList.Count - 1; genx++)
            Parallel.For(0, Data.GeneDataList.Count, genx => 
            {
                GeneData geneData = Data.GeneDataList[genx];
                string sequence = geneData.Sequence;
                long seqTotal = 0;
                //loop genes
                //for (int index = geneData.First; index <= geneData.Last; index++)
                int first = geneData.First;
                int last = geneData.Last;
                //var pres = Parallel.For(first, last, index =>
                for (int index = first; index <= last; index++)
                {
                    {
                        string gene = Data.Genes[index];
                        int position = sequence.IndexOf(gene, 0);
                        while (position >= 0)
                        {
                            seqTotal += Data.GenesHealth[gene][index];
                            position = sequence.IndexOf(gene, ++position);
                        }
                    }
                }

                sequenceScores[genx] = seqTotal;
            });

            result[0] = sequenceScores.Min();
            result[1] = sequenceScores.Max();

            return result;
        }

        public long[] GetHealthAC(FunctionData Data)
        {
            long[] result = new long[2];
            long[] sequenceScores = new long[Data.GeneDataList.Count];
            // loop the sequences
            //for (int genx = 0; genx <= Data.GeneDataList.Count - 1; genx++)
            Parallel.For(0, Data.GeneDataList.Count, genx =>
            {
                GeneData geneData = Data.GeneDataList[genx];
                string sequence = geneData.Sequence;

                string text = geneData.Sequence;// "hello, hello and welcome to this beautiful world!";

                Trie trie = new Trie();

                trie.Add(Data.Genes);
                trie.Build();

                Dictionary<string, int> matches = trie.FindString(text);
                foreach(KeyValuePair<string, int> match in matches)
                {
                    sequenceScores[genx] += Data.GenesHealth[match.Key].ElementAt(match.Value - 1).Value;
                }

                
            });

            result[0] = sequenceScores.Min();
            result[1] = sequenceScores.Max();

            return result;
        }

    }
    public class FunctionData
    {
        public FunctionData()
        {
            GeneDataList = new List<GeneData>();
            GenesHealth = new Dictionary<string, Dictionary<int, int>>();
        }
        public int GeneCount { get; set; }
        public Dictionary<string, Dictionary<int, int>> GenesHealth { get; set; }
        public string[] Genes { get; set; }
        public int[] Health { get; set; }
        public List<GeneData> GeneDataList { get; set; }

        public int MinFirst { get; set; }
        public int MaxLast { get; set; }

    }

    public class GeneData
    {
        public int First { get; set; }
        public int Last { get; set; }
        public string Sequence { get; set; }
    }
}


/*
        //commented parallel

        public long[] GetHealth(FunctionData Data)
        {
            long[] result = new long[2];
            long[] sequenceScores = new long[Data.GeneDataList.Count];
            // loop the sequences
            for (int genx = 0; genx <= Data.GeneDataList.Count - 1; genx++)
            //Parallel.For(0, Data.GeneDataList.Count, genx => 
            {
                GeneData geneData = Data.GeneDataList[genx];
                string sequence = geneData.Sequence;
                long seqTotal = 0;
                //loop genes
                //for (int index = geneData.First; index <= geneData.Last; index++)
                int first = geneData.First;
                int last = geneData.Last;
                //var pres = Parallel.For(first, last, index =>
                for (int index = first; index <= last; index++)
                {
                    {
                        string gene = Data.Genes[index];
                        int position = sequence.IndexOf(gene, 0);
                        while (position >= 0)
                        {
                            seqTotal += Data.GenesHealth[gene][index];
                            position = sequence.IndexOf(gene, ++position);
                        }
                    }
                }//);

                sequenceScores[genx] = seqTotal;
            }//);

            result[0] = sequenceScores.Min();
            result[1] = sequenceScores.Max();

            return result;        
        }


        //swapped to loop gene sequence then search genes
        public long[] GetHealth(FunctionData Data)
        {
            long[] result = new long[2];
            long[] sequenceScores = new long[Data.GeneDataList.Count];
            // loop the sequences
            for (int genx = 0; genx <= Data.GeneDataList.Count - 1; genx++)
            {
                GeneData geneData = Data.GeneDataList[genx];
                string sequence = geneData.Sequence;
                long seqTotal = 0;
                //loop genes
                for (int index = geneData.First; index <= geneData.Last; index++)
                {
                    string gene = Data.Genes[index];
                    int position = sequence.IndexOf(gene, 0);
                    while (position >= 0)
                    {
                        seqTotal += Data.GenesHealth[gene][index];
                        position = sequence.IndexOf(gene, ++position);
                    }
                }

                sequenceScores[genx] = seqTotal;
            }

            result[0] = sequenceScores.Min();
            result[1] = sequenceScores.Max();

            return result;        
        }

        // loop genes then gene sequence
        for (int index = Data.MinFirst; index <= Data.MaxLast; index++)
        {
            //long seqTotal = 0;
            //loop genes
            for (int genx = 0; genx <= Data.GeneDataList.Count - 1; genx++)
            {
                GeneData geneData = Data.GeneDataList[genx];
                if (index >= geneData.First && index <= geneData.Last)
                {
                    string sequence = geneData.Sequence;
                    string gene = Data.Genes[index];
                    int position = sequence.IndexOf(gene, 0);
                    while (position >= 0)
                    {
                        //seqTotal += Data.GenesHealth[gene][index];
                        sequenceScores[genx] += Data.GenesHealth[gene][index];
                        position = sequence.IndexOf(gene, ++position);
                    }

                }
            }

        }


                    
                    //int len = gene.Length;
                    //int lengthSeq = sequence.Length - len;
                    //int position = 0;
                    if (sequence.Contains(gene))
                    {
                        for (int position = 0; position <= lengthSeq; position++)
                        {
                            string subSequence = sequence.Substring(position, len);
                            //check if substring matches gene, if so get score and add it.
                            if (subSequence == gene)
                            {
                                seqTotal += Data.GenesHealth[gene][index];// Data.Health[index];
                            }
                        }
                    }
                    



*loop sequence
            // loop the sequences
            for (int genx = 0; genx <= Data.GeneDataList.Count - 1; genx++)
            {
                GeneData geneData = Data.GeneDataList[genx];
                sequenceScores.Add(geneData.Sequence, 0); //initialize gene scores
                //loop genes
                for(int position = 0; position <= geneData.Sequence.Length; position++)
                {
                    for (int index = geneData.First; index <= geneData.Last; index++)
                    {

                        //pull sub string from start position to length of gene string
                        // make sure not to have an end point beyond the length of the string...
                        int len = Data.Genes[index].Length;
                        if (len + position <= geneData.Sequence.Length)
                        {
                            string subSequence = geneData.Sequence.Substring(position, len);
                            //check if substring matches gene, if so get score and add it.
                            if (subSequence == Data.Genes[index])
                            {
                                sequenceScores[geneData.Sequence] += Data.Health[index];
                            }
                        }
                    }
                }
            } 





//pull sub string from start position to length of gene string
// make sure not to have an end point beyond the length of the string...
int len = Data.Genes[index].Length;
if (len + position <= geneData.Sequence.Length)
{
    string subSequence = geneData.Sequence.Substring(position, len);
    //check if substring matches gene, if so get score and add it.
    if (subSequence == Data.Genes[index])
    {
        sequenceScores[geneData.Sequence] += Data.Health[index];
    }
}


for (int genx = 0; genx <= Data.GeneDataList.Count - 1; genx++)
{
GeneData geneData = Data.GeneDataList[genx];
sequenceScores.Add(geneData.Sequence, 0); //initialize gene scores
//loop genes

List<string> testedGenes = new List<string>(); // no need to process genes
for (int index = geneData.First; index <= geneData.Last; index++)
{
if (testedGenes.Contains(Data.Genes[index]) == false)
{
    Dictionary<int, int> range = Data.GenesHealth[Data.Genes[index]].Where(r => r.Key >= geneData.First && r.Key <= geneData.Last).ToDictionary(k => k.Key, v => v.Value);
    if (range.Count() > 1)
    {
        foreach (KeyValuePair<int, int> score in range)
        {
            sequenceScores[geneData.Sequence] += score.Value;
            //Data.GenesHealth[Data.Genes[index]][score.Key] = 0;
        }

        testedGenes.Add(Data.Genes[index]);
    }
    else
    {
        // test how many times gene is in sequence 
        int indexOf = geneData.Sequence.IndexOf(Data.Genes[index]);
        while (indexOf >= 0)
        {
            sequenceScores[geneData.Sequence] += Data.Health[index];
            indexOf = geneData.Sequence.IndexOf(Data.Genes[index], indexOf + 1);
        }

        testedGenes.Add(Data.Genes[index]);

    }
}
}

// check if there is more than one gene in the range.
} 


*/
