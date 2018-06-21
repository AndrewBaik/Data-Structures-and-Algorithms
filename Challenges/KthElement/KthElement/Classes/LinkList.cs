using System;
using System.Collections.Generic;
using System.Text;

namespace KthElement.Classes
{
    public class LinkList
    {
        /// <summary>
        /// Pointer that always points to the very first Node
        /// </summary>
        public Node Head { get; set; }

        /// <summary>
        /// Pointer that moves by Node to different Nodes to identification of Nodes
        /// </summary>
        public Node Current { get; set; }

        /// <summary>
        /// Head running pointer to identify the position of a node base on the value of K 
        /// </summary>
        public Node Runner { get; set; }

        /// <summary>
        /// Re-validation of pointer in the Linked List
        /// </summary>
        /// <param name="node"> Input a first Node in the Linked List </param>
        public LinkList(Node node)
        {
            Head = node;
            Current = node;
            Runner = node;
        }

        /// <summary>
        /// Adds a Node O(1) infront of very first Node
        /// </summary>
        /// <param name="node">  Must include name of a Node variable with param of its value </param>
        public void Add(Node node)
        {
            Current = Head;
            // assign the next property to the very first node (node that head is assigned to)
            node.Next = Head;

            // Assign head to a new Node
            Head = node;
        }

        /// <summary>
        /// Method identifing the position of a Node in order of last to first based on the value 'k' user provided.
        /// </summary>
        /// <param name="k"> Its an integer value uses to find the position of a node</param>
        /// <returns> the integer value of K position of a node </returns>
        public int KthElements(int k)
        {
            Current = Head;
            Runner = Head;
            int counter = 0;

            while (Runner.Next != null)
            {
                counter++;
                Runner = Runner.Next;
                if (counter > k)
                {
                    Current = Current.Next;
                }
            }
            return Current.Value;

        }

    }
}
