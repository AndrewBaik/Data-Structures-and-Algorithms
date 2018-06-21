using System;
using Xunit;
using KthElement;
using KthElement.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, 7)]
        [InlineData(1, 6)]  
        [InlineData(2, 5)]
        [InlineData(3, 4)]
        [InlineData(4, 3)]
        [InlineData(5, 2)]
        [InlineData(6, 1)]
        public void TestingForKthElement(int k, int result)
        {
            LinkList ll = new LinkList(new Node(7));
            ll.Add(new Node(6));
            ll.Add(new Node(5));
            ll.Add(new Node(4));
            ll.Add(new Node(3));
            ll.Add(new Node(2));
            ll.Add(new Node(1));
          
            int answer = ll.KthElements(k);

            Assert.Equal(result, answer);    
        }

    }
}
