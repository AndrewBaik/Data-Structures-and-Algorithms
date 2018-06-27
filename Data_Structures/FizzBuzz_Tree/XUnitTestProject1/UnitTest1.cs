using System;
using Xunit;
using FizzBuzz_Tree;
using FizzBuzz_Tree.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CheckingForNodeValueValidationDivisibleByThree()
        {
            Node node1 = new Node();
            Node node2 = new Node();
            Node node3 = new Node();
            Node node4 = new Node();
            Node node5 = new Node();

            node1.Value = 3;
            node2.Value = 6;
            node3.Value = 9;
            node4.Value = 12;
            node5.Value = 18;

            Node n1 = Program.CheckForNode(node1);
            Node n2 = Program.CheckForNode(node2);
            Node n3 = Program.CheckForNode(node3);
            Node n4 = Program.CheckForNode(node4);
            Node n5 = Program.CheckForNode(node5);

            Assert.Equal("Buzz", n1.NewValue);
            Assert.Equal("Buzz", n2.NewValue);
            Assert.Equal("Buzz", n3.NewValue);
            Assert.Equal("Buzz", n4.NewValue);
            Assert.Equal("Buzz", n5.NewValue);
        }

        [Fact]
        public void CheckingForNodeValueValidationDivisibleByFive()
        {
            Node node6 = new Node();
            Node node7 = new Node();
            Node node8 = new Node();
            Node node9 = new Node();
            Node node10 = new Node();

            node6.Value = 5;
            node7.Value = 10;
            node8.Value = 20;
            node9.Value = 35;
            node10.Value = 40;

            Node n6 = Program.CheckForNode(node6);
            Node n7 = Program.CheckForNode(node7);
            Node n8 = Program.CheckForNode(node8);
            Node n9 = Program.CheckForNode(node9);
            Node n10 = Program.CheckForNode(node10);

            Assert.Equal("Fizz", n6.NewValue);
            Assert.Equal("Fizz", n7.NewValue);
            Assert.Equal("Fizz", n8.NewValue);
            Assert.Equal("Fizz", n9.NewValue);
            Assert.Equal("Fizz", n10.NewValue);
        }

        [Fact]
        public void CheckingForNodeValueValidationDivisibleByFifteen()
        {
            Node node11 = new Node();
            Node node12 = new Node();
            Node node13 = new Node();
            Node node14 = new Node();
            Node node15 = new Node();

            node11.Value = 15;
            node12.Value = 30;
            node13.Value = 45;
            node14.Value = 60;
            node15.Value = 90;

            Node n11 = Program.CheckForNode(node11);
            Node n12 = Program.CheckForNode(node12);
            Node n13 = Program.CheckForNode(node13);
            Node n14 = Program.CheckForNode(node14);
            Node n15 = Program.CheckForNode(node15);

            Assert.Equal("FizzBuzz", n11.NewValue);
            Assert.Equal("FizzBuzz", n12.NewValue);
            Assert.Equal("FizzBuzz", n13.NewValue);
            Assert.Equal("FizzBuzz", n14.NewValue);
            Assert.Equal("FizzBuzz", n15.NewValue);
        }
    }
}
