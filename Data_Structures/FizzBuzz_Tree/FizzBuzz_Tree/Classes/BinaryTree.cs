using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz_Tree.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree(Node node)
        {
            Root = node;
        }
    }
}
