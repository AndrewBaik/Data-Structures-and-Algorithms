using System;
using System.Collections.Generic;
using System.Text;

namespace Max_Value.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        public Node Runner { get; set; }


        public BinaryTree(Node node)
        {
            Root = node;
        }

        public int PreOrder(Node root, int max)
        {
            if(max < root.Value)
            {
                max = root.Value;
            }
            if(root.LeftChild != null)
            {
                if( max < PreOrder(root.LeftChild, max))
                {
                    max = PreOrder(root.LeftChild, max);
                }
            }
            if(root.RightChild != null)
            {
                if( max < PreOrder(root.RightChild, max))
                {
                    max = PreOrder(root.RightChild, max);
                }
            }
            return max;
        }

    }
}
