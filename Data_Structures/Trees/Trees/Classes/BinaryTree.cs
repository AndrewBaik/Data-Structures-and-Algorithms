using System;
using System.Collections.Generic;
using System.Text;

namespace Trees.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree(Node node)
        {
            Root = node;
        }

        public void PreOrder(Node root)
        {
            Console.WriteLine(root.Value);

            if (root.LeftChild != null)
            {
                PreOrder(root.LeftChild);
            }

            if (root.RightChild != null)
            {
                PreOrder(root.RightChild);
            }
        }


        public void BreadthFirst(Node root)
        {
            Queue<Node> Breadth = new Queue<Node>();

            Breadth.Enqueue(root);

            while(Breadth.TryPeek(out root))
            {
                Node front = Breadth.Dequeue();
                Console.WriteLine(front.Value);

                if(front.LeftChild != null)
                {
                    Breadth.Enqueue(front.LeftChild);
                }
                if(front.RightChild != null)
                {
                    Breadth.Enqueue(front.RightChild);
                }
            }
        }



        public void InOrder(Node root)
        {
            if (root.LeftChild != null)
            {
                InOrder(root.LeftChild);
            }

            Console.WriteLine(root.Value);

            if (root.RightChild != null)
            {
                InOrder(root.RightChild);
            }
        }


        public void PostOrder(Node root)
        {
            if(root.LeftChild != null)
            {
                PostOrder(root.LeftChild);
            }

            if(root.RightChild != null)
            {
                PostOrder(root.RightChild);
            }
            Console.WriteLine(root.Value);
        }



        public Node Search(Node root, int searchValue)
        {
            if(root.Value == null)
            {
                return null;
            }
            if (root.Value == searchValue)
            {
                return root;
            }
            return Search(root.LeftChild, searchValue) ?? Search(root.RightChild, searchValue);
        }
    }
}
