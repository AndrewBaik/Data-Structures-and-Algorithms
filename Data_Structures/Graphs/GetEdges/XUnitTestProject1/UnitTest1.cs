using System;
using Xunit;
using GetEdges;
using GetEdges.Classes;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestForReturnCorrectTotalCost()
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
            adjacentN5.Add(n5, n8Vert);
            adjacentN6.Add(n6, n7Vert);
            adjacentN7.Add(n7, n6Vert);
            adjacentN8.Add(n8, n5Vert);

            List<Dictionary<Node, Dictionary<Node, int>>> aJ = new List<Dictionary<Node, Dictionary<Node, int>>>();

            aJ.Add(adjacentN1);
            aJ.Add(adjacentN2);
            aJ.Add(adjacentN3);
            aJ.Add(adjacentN4);
            aJ.Add(adjacentN5);
            aJ.Add(adjacentN6);
            aJ.Add(adjacentN7);
            aJ.Add(adjacentN8);


            List<Node> nodeList1 = new List<Node>();
            nodeList1.Add(n1);
            nodeList1.Add(n2);

            List<Node> nodeList2 = new List<Node>();
            nodeList2.Add(n5);
            nodeList2.Add(n8);

            Assert.Equal((true, 2), Program.GetEdge(aJ, nodeList1));
            Assert.Equal((true, 8), Program.GetEdge(aJ, nodeList2));
        }



        [Fact]
        public void TestForReturnFalse()
        {
            Node nd1 = new Node(1);
            Node nd2 = new Node(2);
            Node nd3 = new Node(3);
            Node nd4 = new Node(4);
            Node nd5 = new Node(5);
            Node nd6 = new Node(6);
            Node nd7 = new Node(7);
            Node nd8 = new Node(8);

            List<Dictionary<Node, Dictionary<Node, int>>> adjacentList2 = new List<Dictionary<Node, Dictionary<Node, int>>>();

            AdjacencyList adj2 = new AdjacencyList();

            Dictionary<Node, int> vert = adj2.AddVertices(nd2);
            adj2.CreateAdjList(nd1, vert);

            Dictionary<Node, int> nd1Vert = adj2.AddVertices(nd1);
            Dictionary<Node, int> nd2Vert = adj2.AddVertices(nd2);
            Dictionary<Node, int> nd3Vert = adj2.AddVertices(nd3);
            Dictionary<Node, int> nd4Vert = adj2.AddVertices(nd4);
            Dictionary<Node, int> nd5Vert = adj2.AddVertices(nd5);
            Dictionary<Node, int> nd6Vert = adj2.AddVertices(nd6);
            Dictionary<Node, int> nd7Vert = adj2.AddVertices(nd7);
            Dictionary<Node, int> nd8Vert = adj2.AddVertices(nd8);

            Dictionary<Node, Dictionary<Node, int>> adjacentNd1 = new Dictionary<Node, Dictionary<Node, int>>();
            Dictionary<Node, Dictionary<Node, int>> adjacentNd2 = new Dictionary<Node, Dictionary<Node, int>>();
            Dictionary<Node, Dictionary<Node, int>> adjacentNd3 = new Dictionary<Node, Dictionary<Node, int>>();
            Dictionary<Node, Dictionary<Node, int>> adjacentNd4 = new Dictionary<Node, Dictionary<Node, int>>();
            Dictionary<Node, Dictionary<Node, int>> adjacentNd5 = new Dictionary<Node, Dictionary<Node, int>>();
            Dictionary<Node, Dictionary<Node, int>> adjacentNd6 = new Dictionary<Node, Dictionary<Node, int>>();
            Dictionary<Node, Dictionary<Node, int>> adjacentNd7 = new Dictionary<Node, Dictionary<Node, int>>();
            Dictionary<Node, Dictionary<Node, int>> adjacentNd8 = new Dictionary<Node, Dictionary<Node, int>>();

            adjacentNd1.Add(nd1, nd2Vert);
            adjacentNd2.Add(nd2, nd1Vert);
            adjacentNd3.Add(nd3, nd4Vert);
            adjacentNd4.Add(nd4, nd3Vert);
            adjacentNd4.Add(nd5, nd8Vert);
            adjacentNd5.Add(nd6, nd7Vert);
            adjacentNd6.Add(nd7, nd6Vert);
            adjacentNd7.Add(nd8, nd5Vert);

            List<Dictionary<Node, Dictionary<Node, int>>> aJ2 = new List<Dictionary<Node, Dictionary<Node, int>>>();

            aJ2.Add(adjacentNd1);
            aJ2.Add(adjacentNd2);
            aJ2.Add(adjacentNd3);
            aJ2.Add(adjacentNd4);
            aJ2.Add(adjacentNd5);
            aJ2.Add(adjacentNd6);
            aJ2.Add(adjacentNd7);
            aJ2.Add(adjacentNd8);

            List<Node> nodeList3 = new List<Node>();
            nodeList3.Add(nd1);
            nodeList3.Add(nd6);

            List<Node> nodeList4 = new List<Node>();
            nodeList4.Add(nd2);
            nodeList4.Add(nd4);

            Assert.Equal((false,0), Program.GetEdge(aJ2, nodeList3));
            Assert.Equal((false, 0), Program.GetEdge(aJ2, nodeList4));
        }
    }
}
