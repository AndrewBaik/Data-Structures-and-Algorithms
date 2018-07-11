using System;
using Xunit;
using Implement_Graph;
using Implement_Graph.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {

        [Fact]
        public void CheckForAddEdge()
        {
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Graph graph = new Graph(n1);
            graph.AddEdge(n1, n2);

            Assert.Contains(n2, n1.GetNeighbors());
        }

        [Fact]
        public void CheckingForCorrectNumberOfNodesInAGraph()
        {
            Node n1 = new Node(1);
            Graph graph = new Graph(n1);

            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);

            graph.AddEdge(n1, n2);
            graph.AddEdge(n1, n3);
            graph.AddEdge(n2, n4);
            graph.AddEdge(n2, n5);
            graph.AddEdge(n3, n6);

            Assert.Equal(6, graph.Size(n1));
        }

        [Fact]
        public void CheckingForCorrectNumberOfNodesConnected()
        {
            Node n1 = new Node(1);
            Graph graph = new Graph(n1);

            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);

            graph.AddEdge(n1, n2);
            graph.AddEdge(n1, n3);
            graph.AddEdge(n2, n4);
            graph.AddEdge(n2, n5);
            graph.AddEdge(n3, n6);

            int n1Count = n1.GetNeighbors().Count;
            int n2Count = n2.GetNeighbors().Count;
            int n3Count = n3.GetNeighbors().Count;
            int n4Count = n4.GetNeighbors().Count;
            int n5Count = n5.GetNeighbors().Count;
            int n6Count = n6.GetNeighbors().Count;

            Assert.Equal(2, n1Count);
            Assert.Equal(3, n2Count);
            Assert.Equal(2, n3Count);
            Assert.Equal(1, n4Count);
            Assert.Equal(1, n5Count);
            Assert.Equal(1, n6Count);
        }
    }
}
