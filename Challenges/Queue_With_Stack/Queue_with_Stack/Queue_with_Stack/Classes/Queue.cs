using System;
using System.Collections.Generic;
using System.Text;
using Queue_with_Stack;

namespace Queue_with_Stack.Classes
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
    }
}
