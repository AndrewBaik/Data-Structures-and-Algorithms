using System;
using Trees.Classes;

namespace Trees
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Node firstNodeBrt = new Node(100);
            BinarySearchTree binarySearchTree = new BinarySearchTree(firstNodeBrt);
            binarySearchTree.Add(firstNodeBrt, new Node(50));
            binarySearchTree.Add(firstNodeBrt, new Node(150));

            Console.WriteLine("Binary Search Tree");
            Console.WriteLine($"Root: {firstNodeBrt}, Left: {firstNodeBrt.LeftChild.Value}, Right: {firstNodeBrt.RightChild.Value}");
            Console.WriteLine();

            Node firstNodeBt = new Node(100);
            BinaryTree binaryTree = new BinaryTree(firstNodeBt);
            firstNodeBt.LeftChild = new Node(50);
            firstNodeBt.RightChild = new Node(21);

            Console.WriteLine("Binary Tree");
            Console.WriteLine($"Root: {firstNodeBt.Value}, Left: {firstNodeBt.LeftChild.Value}, Right: {firstNodeBt.RightChild.Value}");
        }
    }
}

