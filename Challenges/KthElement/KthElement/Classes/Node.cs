using System;
using System.Collections.Generic;
using System.Text;

namespace KthElement.Classes
{
    public class Node
    {
        /// <summary>
        /// Setting its Value for a Node
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Setting its pointer to a Node that comes after
        /// </summary>
        public Node Next { get; set; }
        
        /// <summary>
        /// Method to generage a new Node
        /// </summary>
        /// <param name="value"> integer assign to newly created Node</param>
        public Node(int value)
        {
            Value = value;
        }
    }
}
