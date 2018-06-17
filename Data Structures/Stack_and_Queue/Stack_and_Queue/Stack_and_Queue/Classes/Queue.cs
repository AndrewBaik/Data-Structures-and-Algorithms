using System;
using System.Collections.Generic;
using System.Text;
using Stack_and_Queue;

namespace Stack_and_Queue.Classes
{
    public class Queue
    {
        /// <summary>
        /// Node reference point always facing the last node of the Queue
        /// </summary>
        public Node Rear { get; set; }

        /// <summary>
        /// Node reference point always facing the first node of the Queue
        /// </summary>
        public Node Front { get; set; }

        /// <summary>
        /// Node reference point used when node is being added or removed
        /// </summary>
        public Node Temp { get; set; }

        /// <summary>
        /// Default set for when Queue is created
        /// </summary>
        /// <param name="node"> Very first Node while declaring a Queue </param>
        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }

        /// <summary>
        /// Method used when a Node is being added to a Queue
        /// </summary>
        /// <param name="node"> Node being created</param>
        public void Enqueue(Node node)
        {
            Rear.Next = node;
            Rear = node;
        }

        /// <summary>
        /// Method used when a Node is being removed for a Queue.
        /// </summary>
        /// <returns> returns the Node being removed </returns>
        public Node Dequeue()
        {
            Temp = Front;
            Front = Front.Next;
            Temp.Next = null;

            return Temp;
        }

        /// <summary>
        /// Reference point of a first Node
        /// </summary>
        /// <returns> Node where Front is referencing </returns>
        public Node Peek()
        {
            return Front;
        }

        /// <summary>
        /// Method to display the value and next values of each nodes included in the Queue.
        /// </summary>
        public void Print()
        {
            Temp = Front;
            while(Temp.Next != null)
            {
                Console.Write($"value= {Temp.Value}, next = {Temp.Next.Value}  ----> ");
                Temp = Temp.Next;
            }
        }

    }
}
