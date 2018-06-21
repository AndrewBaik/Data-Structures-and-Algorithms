using System;
using System.Collections.Generic;
using System.Text;
using MergeLinkedList;

namespace MergeLinkedList.Classes
{
    public class LinkList
    {
        public Node Current { get; set; }
        public Node Head { get; set; }
        public Node Runner { get; set; }
        
        public LinkList(Node node)
        {
            Head = node;
            Current = node;
        }

        public void Add(Node node)
        {
            node.Next = Head;
            Current = Head;
            Head = node;
        }

        public void Print()
        {
            Current = Head;

            while (Current.Next != null)
            {
                Console.Write($"{Current.Value} -->  ");
                Current = Current.Next;
            }

            // to have visual on Console
            Console.Write($"{Current.Value} --> NULL");
        }
    }


}
