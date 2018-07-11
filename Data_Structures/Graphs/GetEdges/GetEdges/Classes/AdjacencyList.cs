using System;
using System.Collections.Generic;
using System.Text;

namespace GetEdges.Classes
{
    public class AdjacencyList
    {
        public Dictionary<Node, int> AddVertices(Node node)
        {
            Dictionary<Node, int> vert = new Dictionary<Node, int>();
            vert.Add(node, node.Value);
            return vert;
        }

        public void CreateAdjList(Node node, Dictionary<Node, int> vertices)
        {
            Dictionary<Node, Dictionary<Node, int>> adj = new Dictionary<Node, Dictionary<Node, int>>();
            adj.Add(node, vertices);
        }

    }
}
