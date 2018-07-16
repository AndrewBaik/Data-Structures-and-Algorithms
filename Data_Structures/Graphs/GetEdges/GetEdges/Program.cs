using GetEdges.Classes;
using System;
using System.Collections.Generic;

namespace GetEdges
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);
            Node n8 = new Node(8);

            List<Dictionary<Node, Dictionary<Node, int>>> adjacentList = new List<Dictionary<Node, Dictionary<Node, int>>>();

            AdjacencyList adj = new AdjacencyList();

            Dictionary<Node, int> vert = adj.AddVertices(n2);
            adj.CreateAdjList(n1, vert);

            Dictionary<Node, int> n1Vert = adj.AddVertices(n1);
            Dictionary<Node, int> n2Vert = adj.AddVertices(n2);
            Dictionary<Node, int> n3Vert = adj.AddVertices(n3);
            Dictionary<Node, int> n4Vert = adj.AddVertices(n4);
            Dictionary<Node, int> n5Vert = adj.AddVertices(n5);
            Dictionary<Node, int> n6Vert = adj.AddVertices(n6);
            Dictionary<Node, int> n7Vert = adj.AddVertices(n7);
            Dictionary<Node, int> n8Vert = adj.AddVertices(n8);

            Dictionary<Node, Dictionary<Node, int>> adjacentN1 = new Dictionary<Node, Dictionary<Node, int>>();
            Dictionary<Node, Dictionary<Node, int>> adjacentN2 = new Dictionary<Node, Dictionary<Node, int>>();
            Dictionary<Node, Dictionary<Node, int>> adjacentN3 = new Dictionary<Node, Dictionary<Node, int>>();
            Dictionary<Node, Dictionary<Node, int>> adjacentN4 = new Dictionary<Node, Dictionary<Node, int>>();
            Dictionary<Node, Dictionary<Node, int>> adjacentN5 = new Dictionary<Node, Dictionary<Node, int>>();
            Dictionary<Node, Dictionary<Node, int>> adjacentN6 = new Dictionary<Node, Dictionary<Node, int>>();
            Dictionary<Node, Dictionary<Node, int>> adjacentN7 = new Dictionary<Node, Dictionary<Node, int>>();
            Dictionary<Node, Dictionary<Node, int>> adjacentN8 = new Dictionary<Node, Dictionary<Node, int>>();

            adjacentN1.Add(n1, n2Vert);
            adjacentN2.Add(n2, n1Vert);
            adjacentN3.Add(n3, n4Vert);
            adjacentN4.Add(n4, n3Vert);
            adjacentN4.Add(n5, n8Vert);
            adjacentN5.Add(n6, n7Vert);
            adjacentN6.Add(n7, n6Vert);
            adjacentN7.Add(n8, n5Vert);

            List<Dictionary<Node, Dictionary<Node, int>>> aJ = new List<Dictionary<Node, Dictionary<Node, int>>>();

            aJ.Add(adjacentN1);
            aJ.Add(adjacentN2);
            aJ.Add(adjacentN3);
            aJ.Add(adjacentN4);
            aJ.Add(adjacentN5);
            aJ.Add(adjacentN6);
            aJ.Add(adjacentN7);
            aJ.Add(adjacentN8);

            List<Node> nodeList = new List<Node>();
            nodeList.Add(n3);
            nodeList.Add(n1);

            Console.WriteLine(GetEdge(aJ, nodeList));

            List<Node> nodeList2 = new List<Node>();
            nodeList2.Add(n5);
            nodeList2.Add(n8);

            Console.WriteLine(GetEdge(aJ, nodeList));

        }




        public static (bool, int) GetEdge(List<Dictionary<Node, Dictionary<Node, int>>> adjacentList, List<Node> nodeList)
        {
            int totalCost = 0;
            Queue que = new Queue();

            foreach(Node node in nodeList)
            {
                que.Enqueue(node);
            }

            foreach(var keyValues in adjacentList)
            {

                if (keyValues.ContainsKey(que.Front) && keyValues[que.Front].ContainsValue(que.Front.Next.Value))
                {
                    Dictionary<Node, int> value = new Dictionary<Node, int>();
                    value.Add(que.Front.Next, que.Front.Next.Value);

                        totalCost += que.Front.Next.Value;
                        que.Dequeue();

                }

                if(que.Front.Next == null)
                {
                    return (true, totalCost);
                }

            }

            return (false, 0);

        }

    }
}
