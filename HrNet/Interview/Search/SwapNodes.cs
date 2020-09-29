using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HrNet.Interview.Search
{
    public class SwapNodes
    {
        public  int[][] swapNodes(int[][] indexes, int[] queries)
        {
            int[][] res = new int[queries.Length][];
            Node node = GetTree(indexes);
            // now do the swaps
            for(int index = 0; index <= queries.Length - 1; index++)
            {
                SwapNodesAt(node, queries[index], 1);
                // walk the tree for results
                List<int> result = new List<int>();
                TraverseTree(node, result);
                res[index] = result.ToArray();
            }


            return res;
        }

        /// <summary>
        /// recursivly walk tree, at given level swap child nodes.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="swap"></param>
        /// <param name="level"></param>
        public void SwapNodesAt(Node node, int swap, int level)
        {
            if (level % swap == 0)
            {
                Node left = node.Left;
                node.Left = node.Right;
                node.Right = left;
            }

            level++;
            if (node.Left != null)
            {
                SwapNodesAt(node.Left, swap, level);
            }

            if (node.Right != null)
            {
                SwapNodesAt(node.Right, swap, level);
            }
        }

        /// <summary>
        /// return a integer list from the in order tree traversal
        /// </summary>
        /// <param name="node"></param>
        /// <param name="Result"></param>
        public void TraverseTree(Node node, List<int> Result)
        {
            if (node.Left != null)
            {
                TraverseTree(node.Left, Result);
            }
            Result.Add(node.index);
            if (node.Right != null)
            {
                TraverseTree(node.Right, Result);
            }
            
        }

        /// <summary>
        /// kick off the tree build, initialize the root and then call the recursive function
        /// </summary>
        /// <param name="Indexes"></param>
        /// <returns></returns>
        public Node GetTree(int[][] Indexes)
        {
            Node node = new Node() { index = 1 };
            if (Indexes[0][0] > -1)
            {
                node.Left = AddNode(Indexes[0][0], Indexes);
            }

            if (Indexes[0][1] > -1)
            {

                node.Right = AddNode(Indexes[0][1], Indexes);
            }

            return node;
        }

        /// <summary>
        /// build the tree recursivly from the input int[][]
        /// </summary>
        /// <param name="Index"></param>
        /// <param name="Indexes"></param>
        /// <returns></returns>
        public Node AddNode(int Index, int[][] Indexes)
        {
            Node node = new Node() { index = Index };
            if (Indexes[Index - 1][0] > -1)
            {
                node.Left = AddNode(Indexes[Index - 1][0], Indexes);
            }

            if (Indexes[Index - 1][1] > -1)
            {
                node.Right = AddNode(Indexes[Index - 1][1], Indexes);
            }

            return node;
        }
    }




    public class Node
    {
        public int index;
        public Node Left { get; set; }
        public Node Right { get; set; }

    }
}


