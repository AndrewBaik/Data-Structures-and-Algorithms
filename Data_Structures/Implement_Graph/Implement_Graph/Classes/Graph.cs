using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Implement_Graph.Classes
{
    public class Graph
    {
        public Node Root { get; set; }

        public Graph(Node node)
        {
            Root = node;
        }
        

        /// <summary>
        /// Adds a new verticle to the graph
        /// </summary>
        public void AddEdge(Node existNode, Node newNode)
        {
            existNode.Children.Add(newNode);
            newNode.Children.Add(existNode);
        }

        /// <summary>
        /// Returns all the nodes in a graph as a collection (Depth first method)
        /// </summary>  
        public List<Node> GetNodes(Node root)
        {
            return BreadthFirst(root);
        }

        // <summary>
        // Returns the total number of Nodes in the graph
        // </summary>
        public int Size(Node root)
        {
            return BreadthFirst(root).Count;
        }

        /// <summary>
        /// Takes in a root node, and returns a collection of all nodes visited in order
        /// </summary>
        public List<Node> BreadthFirst(Node root)
        {
            List<Node> order = new List<Node>();
            Queue<Node> breadth = new Queue<Node>();
            breadth.Enqueue(root);
            root.Visited = true;

            while (breadth.TryPeek(out root))
            {
                Node front = breadth.Dequeue();
                order.Add(front);

                foreach (Node child in front.Children)
                {
                    if (!child.Visited)
                    {
                        child.Visited = true;   
                        breadth.Enqueue(child);
                    }
                }
            }

            foreach( Node node in order)
            {
                node.Visited = false;
            }

            return order;
        }
    }
}
