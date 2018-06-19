using System;
using Xunit;
using Stack_and_Queue;
using Stack_and_Queue.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]  
        public void TestForStackPush()
        {
            Stack testStackPush = new Stack(new Node(1));
            testStackPush.Push(new Node(2));
            testStackPush.Push(new Node(3));
            testStackPush.Push(new Node(4));
            testStackPush.Push(new Node(5));

            int answer = testStackPush.Peek.Value;
            int answer2 = testStackPush.Peek.Next.Value;
            int answer3 = testStackPush.Peek.Next.Next.Value;
            int answer4 = testStackPush.Peek.Next.Next.Next.Value;
            int answer5 = testStackPush.Peek.Next.Next.Next.Next.Value;
            Assert.Equal(5, answer);
            Assert.Equal(4, answer2);
            Assert.Equal(3, answer3);
            Assert.Equal(2, answer4);
            Assert.Equal(1, answer5);
        }

        [Fact]
        public void TestForStackPop()
        {
            Stack testStackPop = new Stack(new Node(1));
            testStackPop.Push(new Node(2));
            testStackPop.Push(new Node(3));
            testStackPop.Push(new Node(4));
            testStackPop.Push(new Node(5));
            testStackPop.Pop();

            int answer = testStackPop.Peek.Value;
            Assert.Equal(4, answer);
        }

        [Fact]
        public void TestForStackPeek()
        {
            Stack testStackPeek = new Stack(new Node(1));
            testStackPeek.Push(new Node(2));
            testStackPeek.Push(new Node(3));
            testStackPeek.Push(new Node(4));
            testStackPeek.Push(new Node(5));
            Node answer = testStackPeek.Peeks();

            Assert.Equal(5, answer.Value);
            Assert.Equal(4, answer.Next.Value);
        }

        [Fact]
        public void TestForQueueEnqueue()
        {
            Queue TestQueueEnqueue = new Queue(new Node(6));
            TestQueueEnqueue.Enqueue(new Node(7));
            TestQueueEnqueue.Enqueue(new Node(8));
            TestQueueEnqueue.Enqueue(new Node(9));
            TestQueueEnqueue.Enqueue(new Node(10));

            int answer = TestQueueEnqueue.Front.Value;
            int answer2 = TestQueueEnqueue.Front.Next.Value;
            int answer3 = TestQueueEnqueue.Front.Next.Next.Value;
            int answer4 = TestQueueEnqueue.Front.Next.Next.Next.Value;

            Assert.Equal(6, answer);
            Assert.Equal(7, answer2);
            Assert.Equal(8, answer3);
            Assert.Equal(9, answer4);
        }

        [Fact]
        public void TestForQueueDequeue()
        {
            Queue TestQueueDequeue = new Queue(new Node(1));
            TestQueueDequeue.Enqueue(new Node(2));
            TestQueueDequeue.Enqueue(new Node(3));
            TestQueueDequeue.Enqueue(new Node(4));
            TestQueueDequeue.Enqueue(new Node(5));

            TestQueueDequeue.Dequeue();

            int answer = TestQueueDequeue.Front.Value;

            Assert.Equal(2, answer);
        }

        [Fact]
        public void TestForQueuePeek()
        {
            Queue TestQueuePeek = new Queue(new Node(1));
            TestQueuePeek.Enqueue(new Node(2));
            TestQueuePeek.Enqueue(new Node(3));
            TestQueuePeek.Enqueue(new Node(4));
            TestQueuePeek.Enqueue(new Node(5));

            Node answer = TestQueuePeek.Peek();
            Assert.Equal(1, answer.Value);
        }
    }
}
