using System;
using System.Collections.Generic;
using System.Text;

namespace LinkList.Classes
{
    public class LinkdList
    {
        /// <summary>
        /// Always point to the first Node
        /// </summary>
        public Node Head { get; set; }

        /// <summary>
        /// The node that is used to traverse through the LinkedList
        /// </summary>
        public Node Current { get; set; }

        /// <summary>
        /// Requiring at least one Node to be present for a LL to be created
        /// </summary>
        /// <param name="node"></param>
        public LinkdList(Node node)
        {
            Head = node;
            Current = node;
        }


        // Add a Node O(1) 
        public void Add(Node node)
        {
            Current = Head;
            // assign the next property to the very first node (node that head is assigned to)
            node.Next = Head;

            // Assign head to a new Node
            Head = node;
        }

        // Find a Node O(n)
        public Node Find(int value)
        {
            Current = Head;

            while (Current.Next != null)
            {
                if (Current.Value == value)
                {
                    return Current;
                }
                Current = Current.Next;
            }
            return Current.Value == value ? Current : null;
        }

        // Print out the Node O(n)
        public void Print()
        {
            Current = Head;

            while (Current.Next != null)
            {
                Console.Write($"{Current.Value} ---> ");
                Current = Current.Next;
            }

            // Visual representation
            Console.Write($"{Current.Value} --> Null");
        }

        // Adds a node before an existing Node O(n)
        public void AddBefore(Node newNode, Node existingNode)
        {
            // Reset our Current to the beginning of the Linked List
            Current = Head;
            if (Head.Value == Current.Value)
            {
                Add(newNode);
            }

            while (Current.Next != null)
            {

                if (Current.Next.Value == existingNode.Value)
                {
                    newNode.Next = existingNode;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }
        }

        // Add a node after an existing Node O(n)
        public void AddAfter(Node newNode, Node existingNode)
        {
            Current = Head;
            if (existingNode.Next == null)
            {
                existingNode.Next = newNode;
                return;
            }

            while (Current.Next != null)
            {
                if (Current.Value == existingNode.Value)
                {
                    newNode.Next = Current.Next;
                    Current.Next = existingNode;
                    return;
                }
                Current = Current.Next;
            }
        }

        // Add a Node at the end of Linked list
        public void AddLast(Node newNode)
        {
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = newNode;
        }
    }
}
