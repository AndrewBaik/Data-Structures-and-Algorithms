using System;
using System.Collections.Generic;
using System.Text;
using Trees.Classes;

namespace Trees
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public Node Search(Node root, int searchingValue)
        {
            if(root.Value > searchingValue)
            {
                return Search(root.LeftChild, searchingValue);
            }
            if(root.Value < searchingValue)
            {
                return Search(root.RightChild, searchingValue);
            }
            if(root.Value == searchingValue)
            {
                return root;
            }
            else
            {
                return null;
            }
        }

        public void Add(Node root, Node newNode)
        {
            if(root.Value > newNode.Value && root.LeftChild != null)
            {
                Add(root.LeftChild, newNode);
            }
            if(root.Value < newNode.Value && root.RightChild != null)
            {
                Add(root.RightChild, newNode);
            }
            if(root.LeftChild == null && root.RightChild != null)
            {
                root.LeftChild = newNode;
            }
            if(root.RightChild == null && root.LeftChild != null)
            {
                root.RightChild = newNode;
            }
            if(root.RightChild == null && root.LeftChild == null && root.Value > newNode.Value)
            {
                root.LeftChild = newNode;
            }
            if (root.RightChild == null && root.LeftChild == null && root.Value < newNode.Value)
            {
                root.RightChild = newNode;
            }
        }

        public BinarySearchTree(Node node)
        {
            Root = node;
        }
    }
}
