using System;
using System.Collections.Generic;
using System.Text;

namespace GetEdges.Classes
{
    public class Node
    {
        public int Value { get; set; }
        public bool Visted { get; set; } = false;
        public Node Next { get; set; }

        public Node(int val)
        {
            Value = val;
        }
    }
}
