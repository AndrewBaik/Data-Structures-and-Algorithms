using System;
using System.Collections.Generic;
using System.Text;
using Queue_with_Stack;

namespace Queue_with_Stack.Classes
{
    public class Node
    {
        /// <summary>
        /// Value of each Node
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Referencing point that defines the order of node
        /// </summary>
        public Node Next { get; set; }

        /// <summary>
        /// Default set when Node being declared
        /// </summary>
        /// <param name="value"></param>
        public Node(int value)
        {
            Value = value;
        }
    }
}
