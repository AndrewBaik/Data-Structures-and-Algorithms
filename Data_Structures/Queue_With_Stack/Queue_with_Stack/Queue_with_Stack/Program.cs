using System;
using Queue_with_Stack.Classes;

namespace Queue_with_Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack s1 = new Stack(new Node(1));
            s1.Push(new Node(2));
            s1.Push(new Node(3));
            s1.Push(new Node(4));
            Enqueue(s1, 5);
            Dequeue(s1);
        }

        /// <summary>
        /// Functions the enqueue method within Queue, removing the last node(FILO)
        /// </summary>
        /// <param name="stack"> Pre-existing stack with Nodes </param>
        /// <param name="value"> value of a Node being Enqueued </param>
        public static void Enqueue(Stack stack, int value)
        {
            stack.Push(new Node(value));
        }

        /// <summary>
        /// Functions the Dequeue method within Queue, removing the last node in a FILO approach.
        /// </summary>
        /// <param name="stack1"> Pre-existing stack with Nodes </param>
        public static Stack Dequeue(Stack stack1)
        {
            Stack stack2 = new Stack(new Node(stack1.Top.Value));
            stack1.Pop();
            while(stack1.Top.Next != null)
            {
                stack2.Push(stack1.Pop());
            }
            stack1.Pop();

            while(stack2.Top != null)
            {
                stack1.Push(stack2.Pop());
            }
            return stack1;
        }
    }
}
