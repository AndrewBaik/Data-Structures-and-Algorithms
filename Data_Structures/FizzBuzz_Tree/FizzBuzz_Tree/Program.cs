using System;
using FizzBuzz_Tree.Classes;

namespace FizzBuzz_Tree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }

        /// <summary>
        /// Method inputs a binary tree and renders the preorder method for validation of nodes
        /// </summary>
        /// <param name="tree"> given binary tree </param>
        /// <returns> tree with new values </returns>
        public BinaryTree FizzBuzzTree(BinaryTree tree)
        {
            PreOrder(tree.Root);
            return tree;
        }

        /// <summary>
        /// Method validates the node value and replace with Fizz, Buzz, or FizzBuzz
        /// </summary>
        /// <param name="node"> Validating Node </param>
        /// <returns> Node with validated value </returns>
        public static Node CheckForNode(Node node)
        {
            if(node.Value % 15 == 0)
            {
                Node n1 = new Node();
                n1.NewValue = "FizzBuzz";
                n1.LeftChild = node.LeftChild;
                n1.RightChild = node.RightChild;
                return n1;
            }
            else if(node.Value % 5 == 0)
            {
                Node n1 = new Node();
                n1.NewValue = "Fizz";
                n1.LeftChild = node.LeftChild;
                n1.RightChild = node.RightChild;
                return n1;
            }
            else if(node.Value % 3 == 0)
            {
                Node n1 = new Node();
                n1.NewValue = "Buzz";
                n1.LeftChild = node.LeftChild;
                n1.RightChild = node.RightChild;
                return n1;
            }

            return node;
        }

        /// <summary>
        /// Method to check for every Nodes in a binary tree
        /// </summary>
        /// <param name="root">Root node checking for leftchild and rightchild</param>
        public void PreOrder(Node root)
        {
            CheckForNode(root);
            if(root.LeftChild != null)
            {
                PreOrder(root.LeftChild);
            }
            if(root.RightChild != null)
            {
                PreOrder(root.RightChild);
            }
        }

    }
}
