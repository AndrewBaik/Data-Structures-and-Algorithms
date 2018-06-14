using System;
using System.Collections.Generic;
using System.Text;
using MergeLinkedList;

namespace MergeLinkedList.Classes
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
        }

    }
}
