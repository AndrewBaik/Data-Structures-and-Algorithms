using System;
using Xunit;
using MergeLinkedList;
using MergeLinkedList.Classes;

namespace XUnitTestProject2
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1)]
        public void TestingForMergedLinkedListFirstNode(int expectedResult)
        {
            LinkList ll1 = new LinkList(new Node(5));
            ll1.Add(new Node(3));
            ll1.Add(new Node(1));

            LinkList ll2 = new LinkList(new Node(6));
            ll2.Add(new Node(4));
            ll2.Add(new Node(2));

            LinkList ll3 = new LinkList(new Node(7));
            ll3.Add(new Node(5));
            ll3.Add(new Node(3));
            ll3.Add(new Node(1));

            LinkList ll4 = new LinkList(new Node(6));
            ll4.Add(new Node(4));
            ll4.Add(new Node(2));

            LinkList ll5 = new LinkList(new Node(5));
            ll5.Add(new Node(3));
            ll5.Add(new Node(1));

            LinkList ll6 = new LinkList(new Node(7));
            ll6.Add(new Node(6));
            ll6.Add(new Node(4));
            ll6.Add(new Node(2));

            LinkList result = Program.MergeLinkedLists(ll1, ll2);
            LinkList result2 = Program.MergeLinkedLists(ll3, ll4);
            LinkList result3 = Program.MergeLinkedLists(ll5, ll6);
            Assert.Equal(expectedResult, result.Head.Value);
            Assert.Equal(expectedResult, result2.Head.Value);
            Assert.Equal(expectedResult, result3.Head.Value);
        }

        [Theory]
        [InlineData(2)]
        public void TestingForMergedLinkedListSecondNode(int expectedResult)
        {
            LinkList ll1 = new LinkList(new Node(5));
            ll1.Add(new Node(3));
            ll1.Add(new Node(1));

            LinkList ll2 = new LinkList(new Node(6));
            ll2.Add(new Node(4));
            ll2.Add(new Node(2));

            LinkList ll3 = new LinkList(new Node(7));
            ll3.Add(new Node(5));
            ll3.Add(new Node(3));
            ll3.Add(new Node(1));

            LinkList ll4 = new LinkList(new Node(6));
            ll4.Add(new Node(4));
            ll4.Add(new Node(2));

            LinkList ll5 = new LinkList(new Node(5));
            ll5.Add(new Node(3));
            ll5.Add(new Node(1));

            LinkList ll6 = new LinkList(new Node(7));
            ll6.Add(new Node(6));
            ll6.Add(new Node(4));
            ll6.Add(new Node(2));

            LinkList result = Program.MergeLinkedLists(ll1, ll2);
            LinkList result2 = Program.MergeLinkedLists(ll3, ll4);
            LinkList result3 = Program.MergeLinkedLists(ll5, ll6);
            Assert.Equal(expectedResult, result.Head.Next.Value);
            Assert.Equal(expectedResult, result2.Head.Next.Value);
            Assert.Equal(expectedResult, result3.Head.Next.Value);
        }

        [Theory]
        [InlineData(3)]
        public void TestingForMergedLinkedListThirdNode(int expectedResult)
        {
            LinkList ll1 = new LinkList(new Node(5));
            ll1.Add(new Node(3));
            ll1.Add(new Node(1));

            LinkList ll2 = new LinkList(new Node(6));
            ll2.Add(new Node(4));
            ll2.Add(new Node(2));

            LinkList ll3 = new LinkList(new Node(7));
            ll3.Add(new Node(5));
            ll3.Add(new Node(3));
            ll3.Add(new Node(1));

            LinkList ll4 = new LinkList(new Node(6));
            ll4.Add(new Node(4));
            ll4.Add(new Node(2));

            LinkList ll5 = new LinkList(new Node(5));
            ll5.Add(new Node(3));
            ll5.Add(new Node(1));

            LinkList ll6 = new LinkList(new Node(7));
            ll6.Add(new Node(6));
            ll6.Add(new Node(4));
            ll6.Add(new Node(2));

            LinkList result = Program.MergeLinkedLists(ll1, ll2);
            LinkList result2 = Program.MergeLinkedLists(ll3, ll4);
            LinkList result3 = Program.MergeLinkedLists(ll5, ll6);
            Assert.Equal(expectedResult, result.Head.Next.Next.Value);
            Assert.Equal(expectedResult, result2.Head.Next.Next.Value);
            Assert.Equal(expectedResult, result3.Head.Next.Next.Value);
        }

        [Theory]
        [InlineData(4)]
        public void TestingForMergedLinkedListFourthNode(int expectedResult)
        {
            LinkList ll1 = new LinkList(new Node(5));
            ll1.Add(new Node(3));
            ll1.Add(new Node(1));

            LinkList ll2 = new LinkList(new Node(6));
            ll2.Add(new Node(4));
            ll2.Add(new Node(2));

            LinkList ll3 = new LinkList(new Node(7));
            ll3.Add(new Node(5));
            ll3.Add(new Node(3));
            ll3.Add(new Node(1));

            LinkList ll4 = new LinkList(new Node(6));
            ll4.Add(new Node(4));
            ll4.Add(new Node(2));

            LinkList ll5 = new LinkList(new Node(5));
            ll5.Add(new Node(3));
            ll5.Add(new Node(1));

            LinkList ll6 = new LinkList(new Node(7));
            ll6.Add(new Node(6));
            ll6.Add(new Node(4));
            ll6.Add(new Node(2));

            LinkList result = Program.MergeLinkedLists(ll1, ll2);
            LinkList result2 = Program.MergeLinkedLists(ll3, ll4);
            LinkList result3 = Program.MergeLinkedLists(ll5, ll6);
            Assert.Equal(expectedResult, result.Head.Next.Next.Next.Value);
            Assert.Equal(expectedResult, result2.Head.Next.Next.Next.Value);
            Assert.Equal(expectedResult, result3.Head.Next.Next.Next.Value);
        }

        [Theory]
        [InlineData(5)]
        public void TestingForMergedLinkedListFifthNode(int expectedResult)
        {
            LinkList ll1 = new LinkList(new Node(5));
            ll1.Add(new Node(3));
            ll1.Add(new Node(1));

            LinkList ll2 = new LinkList(new Node(6));
            ll2.Add(new Node(4));
            ll2.Add(new Node(2));

            LinkList ll3 = new LinkList(new Node(7));
            ll3.Add(new Node(5));
            ll3.Add(new Node(3));
            ll3.Add(new Node(1));

            LinkList ll4 = new LinkList(new Node(6));
            ll4.Add(new Node(4));
            ll4.Add(new Node(2));

            LinkList ll5 = new LinkList(new Node(5));
            ll5.Add(new Node(3));
            ll5.Add(new Node(1));

            LinkList ll6 = new LinkList(new Node(7));
            ll6.Add(new Node(6));
            ll6.Add(new Node(4));
            ll6.Add(new Node(2));

            LinkList result = Program.MergeLinkedLists(ll1, ll2);
            LinkList result2 = Program.MergeLinkedLists(ll3, ll4);
            LinkList result3 = Program.MergeLinkedLists(ll5, ll6);
            Assert.Equal(expectedResult, result.Head.Next.Next.Next.Next.Value);
            Assert.Equal(expectedResult, result2.Head.Next.Next.Next.Next.Value);
            Assert.Equal(expectedResult, result3.Head.Next.Next.Next.Next.Value);
        }

        [Theory]
        [InlineData(6)]
        public void TestingForMergedLinkedListSixthNode(int expectedResult)
        {
            LinkList ll1 = new LinkList(new Node(5));
            ll1.Add(new Node(3));
            ll1.Add(new Node(1));

            LinkList ll2 = new LinkList(new Node(6));
            ll2.Add(new Node(4));
            ll2.Add(new Node(2));

            LinkList ll3 = new LinkList(new Node(7));
            ll3.Add(new Node(5));
            ll3.Add(new Node(3));
            ll3.Add(new Node(1));

            LinkList ll4 = new LinkList(new Node(6));
            ll4.Add(new Node(4));
            ll4.Add(new Node(2));

            LinkList ll5 = new LinkList(new Node(5));
            ll5.Add(new Node(3));
            ll5.Add(new Node(1));

            LinkList ll6 = new LinkList(new Node(7));
            ll6.Add(new Node(6));
            ll6.Add(new Node(4));
            ll6.Add(new Node(2));

            LinkList result = Program.MergeLinkedLists(ll1, ll2);
            LinkList result2 = Program.MergeLinkedLists(ll3, ll4);
            LinkList result3 = Program.MergeLinkedLists(ll5, ll6);
            Assert.Equal(expectedResult, result.Head.Next.Next.Next.Next.Next.Value);
            Assert.Equal(expectedResult, result2.Head.Next.Next.Next.Next.Next.Value);
            Assert.Equal(expectedResult, result3.Head.Next.Next.Next.Next.Next.Value);
        }


        [Theory]
        [InlineData(7)]
        public void TestingForMergedLinkedListSeventhhNode(int expectedResult)
        {
            LinkList ll3 = new LinkList(new Node(7));
            ll3.Add(new Node(5));
            ll3.Add(new Node(3));
            ll3.Add(new Node(1));

            LinkList ll4 = new LinkList(new Node(6));
            ll4.Add(new Node(4));
            ll4.Add(new Node(2));

            LinkList ll5 = new LinkList(new Node(5));
            ll5.Add(new Node(3));
            ll5.Add(new Node(1));

            LinkList ll6 = new LinkList(new Node(7));
            ll6.Add(new Node(6));
            ll6.Add(new Node(4));
            ll6.Add(new Node(2));

            LinkList result2 = Program.MergeLinkedLists(ll3, ll4);
            LinkList result3 = Program.MergeLinkedLists(ll5, ll6);

            Assert.Equal(expectedResult, result2.Head.Next.Next.Next.Next.Next.Next.Value);
            Assert.Equal(expectedResult, result3.Head.Next.Next.Next.Next.Next.Next.Value);
        }
    }
}
