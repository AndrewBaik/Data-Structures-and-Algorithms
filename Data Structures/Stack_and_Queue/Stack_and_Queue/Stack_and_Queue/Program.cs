using System;
using Stack_and_Queue.Classes;

namespace Stack_and_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack();
            Console.WriteLine("-------------------");
            Queue();
            Console.ReadKey();
        }

        /// <summary>
        /// Method to display the example of stack and order of Nodes values and next
        /// </summary>
        static void Stack()
        {
            Stack stack1 = new Stack(new Node(1));
            stack1.Push(new Node(2));
            stack1.Push(new Node(3));
            stack1.Push(new Node(4));
            stack1.Push(new Node(5));

            stack1.Print();
        }

        /// <summary>
        /// Method to display the example of Queue and order of Nodes values and next
        /// </summary>
        static void Queue()
        {
        Queue q1 = new Queue(new Node(6));
            q1.Enqueue(new Node(7));
            q1.Enqueue(new Node(8));
            q1.Enqueue(new Node(9));
            q1.Enqueue(new Node(10));

            q1.Print();
        }
    }
}
