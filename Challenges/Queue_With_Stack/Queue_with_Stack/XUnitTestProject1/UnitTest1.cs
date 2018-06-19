using System;
using Xunit;
using Queue_with_Stack;
using Queue_with_Stack.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestForEnqueueMethod()
        {
            Stack testStack1 = new Stack(new Node(5));
            Program.Enqueue(testStack1, 6);
            Program.Enqueue(testStack1, 7);
            Program.Enqueue(testStack1, 8);
            Program.Enqueue(testStack1, 9);
            
            Assert.Equal(9, testStack1.Top.Value);
        }

        [Fact]
        public void TestForDequeueMethod()
        {
            Stack testStack2 = new Stack(new Node(5));
            testStack2.Push(new Node(4));
            testStack2.Push(new Node(3));
            testStack2.Push(new Node(2));
            testStack2.Push(new Node(1));

            testStack2 = Program.Dequeue(testStack2);

            Assert.Equal(null, testStack2.Top.Next.Next.Next.Next);
        }
    }
}
