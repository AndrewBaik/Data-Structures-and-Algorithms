using System;
using System.Collections.Generic;
using System.Text;

namespace Implement_Graph.Classes
{
    public class Node
    {
        public int Value { get; set; }
        public List<Node> Children { get; set; }
        public bool Visited { get; set; } = false;

        public Node (int value)
        {
            Value = value;
            Children = new List<Node>(); 
        }


        /// <summary>
        /// Returns a collection of nodes connected to the given node
        /// </summary>
        public List<Node> GetNeighbors()
        {
            return Children;
        }
    }
}
