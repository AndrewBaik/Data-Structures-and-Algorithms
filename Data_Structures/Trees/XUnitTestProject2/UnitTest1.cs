using System;
using Xunit;
using Trees;
using Trees.Classes;


namespace XUnitTestProject2
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(100)]
        [InlineData(50)]
        [InlineData(200)]
        [InlineData(25)]
        [InlineData(150)]
        public void TestingForBstAddAndSearchMethods(int included)
        {
            Node bstTest = new Node(100);
            BinarySearchTree bst = new BinarySearchTree(bstTest);
            bst.Add(bst.Root, new Node(50));
            bst.Add(bst.Root, new Node(200));
            bst.Add(bstTest, new Node(25));
            bst.Add(bstTest, new Node(150));

            Node expectedResult = bst.Search(bstTest, included);
            Assert.Equal(included, expectedResult.Value);
        }

        [Theory]
        [InlineData(100)]
        [InlineData(50)]
        public void TestingForBtFindMethod(int value)
        {
            Node btTest = new Node(100);
            BinaryTree btree = new BinaryTree(btTest);
            btTest.LeftChild = new Node(50);

            Node returnNode = btree.Search(btTest, value);

            Assert.Equal(value, returnNode.Value);
        }
    }
}
