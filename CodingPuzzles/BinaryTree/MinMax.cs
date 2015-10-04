using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{
    //Write a method to get the min from a binary tree
    //Write a method to get the max from a binary tree
    partial class BinarySearchTree
    {
        //Returns the data in the farthest left node
        public int GetMin(NodeBT root)
        {
            NodeBT cur = root;
            while (cur.Left != null)
                cur = cur.Left;
            return cur.Data;
        }

        //Returns the data in the farthest right node
        public int GetMax(NodeBT root)
        {
            NodeBT cur = root;
            while (cur.Right != null)
                cur = cur.Right;
            return cur.Data;
        }
        ////Run in Program.cs to test
        //BinarySearchTree bst = new BinarySearchTree();
        //bst.Add(5);
        //bst.Add(10);
        //bst.Add(15);
        //bst.Add(-7);
        //bst.Add(2);
        //bst.Add(26);
        //bst.Add(98);
        //Console.WriteLine(bst.GetMin(bst.Root));
        //Console.WriteLine(bst.GetMax(bst.Root));
    }
}