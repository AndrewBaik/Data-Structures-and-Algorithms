using System;
using System.Collections.Generic;
using System.Text;

namespace GetEdges.Classes
{
    class Graph
    {
        public Node Root { get; set; }

        public Graph(Node node)
        {
            Root = node;
        }
    }
}
