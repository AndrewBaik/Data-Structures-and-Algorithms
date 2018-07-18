using System;
using System.Collections.Generic;
using Tree_Intersection.Classes;

namespace Tree_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {

            Node n1 = new Node(10);
            BinaryTree bt1 = new BinaryTree(n1);
            Node n2 = new Node(15);
            Node n3 = new Node(3);
            Node n4 = new Node(20);
            Node n5 = new Node(16);
            Node n6 = new Node(45);
            Node n7 = new Node(2);
            Node n8 = new Node(65);
            Node n9 = new Node(23);

            n1.LeftChild = n2;
            n1.RightChild = n3;
            n2.LeftChild = n4;
            n2.RightChild = n5;
            n3.LeftChild = n6;
            n3.RightChild = n7;
            n5.LeftChild = n8;
            n7.RightChild = n9;


            Node n10 = new Node(16);
            BinaryTree bt2 = new BinaryTree(n10);
            Node n12 = new Node(32);
            Node n13 = new Node(1);
            Node n14 = new Node(2);
            Node n15 = new Node(18);
            Node n16 = new Node(21);
            Node n17 = new Node(23);
            Node n18 = new Node(42);
            Node n19 = new Node(3);

            n1.LeftChild = n2;
            n1.RightChild = n3;
            n2.LeftChild = n4;
            n2.RightChild = n5;
            n3.LeftChild = n6;
            n3.RightChild = n7;
            n5.LeftChild = n8;
            n7.RightChild = n9;

            //2,23,16,3
            int[] result = TreeIntersection(bt1, bt2);

            for(int i = 0; i < result.Length; i++)
            {
                if(result[i] != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static int[] TreeIntersection(BinaryTree bt1, BinaryTree bt2)
        {
            int[] hs = new int[1024];
            int[] hs2 = new int[1024];
            hs = BreadthFirst(bt1.Root, hs);
            hs2 = BreadthFirst(bt2.Root, hs);
            
            return hs2;    
        }


        public static int[] BreadthFirst(Node root, int[] hs)
        {
            Queue<Node> Breadth = new Queue<Node>();
            bool trigger = false;
            int[] list = new int[1024];

            Breadth.Enqueue(root);

            while (Breadth.TryPeek(out root))
            {
                Node front = Breadth.Dequeue();

                if (front.LeftChild != null)
                {
                    int lIndex = root.LeftChild.Value;
                    if (hs[lIndex] != 0)
                    {
                        list[lIndex] = lIndex;
                    }
                    else
                    {
                        hs[lIndex] = lIndex;
                    }
                    Breadth.Enqueue(front.LeftChild);
                }
                if (front.RightChild != null)
                {
                    int rIndex = root.RightChild.Value;
                    if (hs[rIndex] != 0)
                    {
                        list[rIndex] = rIndex;
                    }
                    else
                    {
                        hs[rIndex] = rIndex;
                    }
                    Breadth.Enqueue(front.RightChild);
                }
            }
            if(trigger)
            {
                return hs;
            }
            else
            {
                return list;
            }
        }
    }
}
