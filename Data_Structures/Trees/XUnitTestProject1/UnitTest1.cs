using System;
using Xunit;
using Trees.Classes;
using Trees;

namespace XUnitTestProject1
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {
            BinarySearchTree.Adds(new Node(100), new Node(50));
        }
    }
}
