using System;
using Xunit;
using Max_Value;
using Max_Value.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CheckingForReturnOfHighestValue1()
        {
            Node n = new Node(8);
            BinaryTree bt1 = new BinaryTree(n);
            Node n1 = new Node(5);
            Node n2 = new Node(4);
            Node n3 = new Node(10);
            Node n4 = new Node(7);
            Node n5 = new Node(14);
            Node n6 = new Node(2);

            n.LeftChild = n1;
            n.RightChild = n2;
            n1.LeftChild = n3;
            n1.RightChild = n4;
            n2.LeftChild = n5;
            n2.RightChild = n6;

            int highestValue = Program.MaxValue(bt1);

            Assert.Equal(14, highestValue);  
        }

        [Fact]
        public void CheckingForReturnOfHighestValueWithNegNumber()
        {
            Node n = new Node(-8);
            BinaryTree bt1 = new BinaryTree(n);
            Node n1 = new Node(-5);
            Node n2 = new Node(-4);
            Node n3 = new Node(-10);
            Node n4 = new Node(-7);
            Node n5 = new Node(-14);
            Node n6 = new Node(-2);

            n.LeftChild = n1;
            n.RightChild = n2;
            n1.LeftChild = n3;
            n1.RightChild = n4;
            n2.LeftChild = n5;
            n2.RightChild = n6;

            int highestValue = Program.MaxValue(bt1);

            Assert.Equal(-2, highestValue);
        }

        [Fact]
        public void CheckingForReturnOfHighestValue2()
        {
            Node n = new Node(1);
            BinaryTree bt1 = new BinaryTree(n);
            Node n1 = new Node(9);
            Node n2 = new Node(12);
            Node n3 = new Node(0);
            Node n4 = new Node(11);
            Node n5 = new Node(9);
            Node n6 = new Node(2);

            n.LeftChild = n1;
            n.RightChild = n2;
            n1.LeftChild = n3;
            n1.RightChild = n4;
            n2.LeftChild = n5;
            n2.RightChild = n6;

            int highestValue = Program.MaxValue(bt1);

            Assert.Equal(12, highestValue);
        }

        [Fact]
        public void CheckingForReturnOfHighestValueWithMultiplesOfSameHighNumber()
        {
            Node n = new Node(1);
            BinaryTree bt1 = new BinaryTree(n);
            Node n1 = new Node(0);
            Node n2 = new Node(-2);
            Node n3 = new Node(0);
            Node n4 = new Node(1);
            Node n5 = new Node(1);
            Node n6 = new Node(0);

            n.LeftChild = n1;
            n.RightChild = n2;
            n1.LeftChild = n3;
            n1.RightChild = n4;
            n2.LeftChild = n5;
            n2.RightChild = n6;

            int highestValue = Program.MaxValue(bt1);

            Assert.Equal(1, highestValue);
        }
    }
}
