using System;
using Implement_Graph.Classes;


namespace Implement_Graph
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Node n1 = new Node(1);
            Graph graph = new Graph(n1);

            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);

            graph.AddEdge(n1, n2);
            Console.WriteLine("Node 1(Root) is connected with Node 2");

            graph.AddEdge(n1, n3);
            Console.WriteLine("Node 1(Root) is connected with Node 3");

            graph.AddEdge(n2, n4);
            Console.WriteLine("Node 2 is connected with Node 4");

            graph.AddEdge(n2, n5);
            Console.WriteLine("Node 2 is connected with Node 5");

            graph.AddEdge(n3, n6);
            Console.WriteLine("Node 3 is connected with Node 6");

            Console.WriteLine();

            Console.Write("Graph contains nodes: ");
            foreach (Node node in graph.GetNodes(n1))
            {
                Console.Write(node.Value + " ");
            }
            Console.WriteLine();

            Console.WriteLine();

            Console.Write("Node 1 ---> ");
            foreach ( Node node in n1.GetNeighbors())
            {
                Console.Write(node.Value + " " );
            }
            Console.WriteLine();

            Console.Write("Node 2 ---> ");
            foreach (Node node in n2.GetNeighbors())
            {
                Console.Write(node.Value + " ");
            }
            Console.WriteLine();

            Console.Write("Node 3 ---> ");
            foreach (Node node in n3.GetNeighbors())
            {
                Console.Write(node.Value + " ");
            }
            Console.WriteLine();

            Console.Write("Node 4 ---> ");
            foreach (Node node in n4.GetNeighbors())
            {
                Console.Write(node.Value + " ");
            }
            Console.WriteLine();

            Console.Write("Node 5 ---> ");
            foreach (Node node in n5.GetNeighbors())
            {
                Console.Write(node.Value + " ");
            }
            Console.WriteLine();

            Console.Write("Node 6 ---> ");
            foreach (Node node in n6.GetNeighbors())
            {
                Console.Write(node.Value + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Graph contains " + graph.Size(n1) + " nodes");
        }
    }
}
