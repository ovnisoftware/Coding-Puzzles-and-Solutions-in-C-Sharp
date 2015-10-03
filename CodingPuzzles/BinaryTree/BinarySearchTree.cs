using System;

namespace CodingPuzzles
{
    //Implement a binary search tree
    public class BinarySearchTree
    {
        public NodeBT Root { get; set; }
        public int Count { get; set; }

        public BinarySearchTree()
        {
            Root = null;
        }

        public void Add(int x)
        {
            NodeBT n = new NodeBT(x);
            if (Root == null)
            {
                Root = n;
                Count++;
                return;
            }
            NodeBT cur = Root;
            while (true)
            {
                if ((cur.Data < n.Data) && (cur.Right != null))
                    cur = cur.Right;
                else if ((cur.Data >= n.Data) && (cur.Left != null))
                    cur = cur.Left;
                else if ((cur.Data < n.Data) && (cur.Right == null))
                {
                    cur.Right = n;
                    return;
                }
                else
                {
                    cur.Left = n;
                    return;
                }
            }
        }

        public void CallInOrderPrint(NodeBT root)
        {
            InOrderPrint(this.Root);
        }

        private void InOrderPrint(NodeBT root)
        {
            if (root == null)
                return;
            InOrderPrint(root.Left);
            Console.WriteLine(root.Data);
            InOrderPrint(root.Right);
        }

        public void Clear()
        {
            Root = null;
            Count = 0;
        }
        //BinarySearchTree bst = new BinarySearchTree();
        //bst.Add(1);
        //bst.Add(3);
        //bst.Add(-5);
        //bst.Add(10);
        //bst.CallInOrderPrint(bst.Root);
    }
}