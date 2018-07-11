using System;
using System.Collections.Generic;
using System.Text;

namespace GetEdges.Classes
{
    class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }
        public Node Peek { get; set; }

        public Queue()
        {

        }

        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }

        public void Enqueue(Node node)
        {
            if(Front == null)
            {
                Front = node;
                Rear = node;
            }
            else
            {
                Rear.Next = node;
                Rear = node;
            }
        }

        public void Dequeue()
        {
            Peek = Front;
            Front = Front.Next;
            Peek.Next = null;
        }
    }
}


