using System;
using System.Collections.Generic;
using System.Text;
using Queue_with_Stack;

namespace Queue_with_Stack.Classes
{
    public class Stack
    {
        /// <summary>
        /// Node reference point always facing the top of the Stack
        /// </summary>
        public Node Top { get; set; }

        /// <summary>
        /// Node reference point used when a node is being added or removed
        /// </summary>
        public Node Temp { get; set; }

        /// <summary>
        /// Default stack values when its first being declared
        /// </summary>
        /// <param name="node"> Node being added when stack is first declared </param>
        public Stack(Node node)
        {
            Top = node;
        }

        /// <summary>
        /// Method to add a Node in the Stack
        /// </summary>
        /// <param name="node"> Node being added </param>
        public void Push(Node node)
        {
            node.Next = Top;
            Top = node;
        }

        /// <summary>
        /// Method to remove a Node from the stack
        /// </summary>
        /// <returns> Node being removed </returns>
        public Node Pop()
        {
            Temp = Top;
            Top = Top.Next;
            Temp.Next = null;
            return Temp;
        }
    }
}
