using System;
using MergeLinkedList.Classes;

namespace MergeLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LinkList ll1 = new LinkList(new Node(5));
            ll1.Add(new Node(3));
            ll1.Add(new Node(1));

            LinkList ll2 = new LinkList(new Node(6));
            ll2.Add(new Node(4));
            ll2.Add(new Node(2));

            LinkList ll3 = new LinkList(new Node(6));
            ll3.Add(new Node(5));
            ll3.Add(new Node(4));
            ll3.Add(new Node(3));
            ll3.Add(new Node(2));
            ll3.Add(new Node(1));


            MergeLinkedLists(ll1, ll2);
            Console.WriteLine("After");
            ll1.Print();
            Console.WriteLine();
            ll3.Print();
        }


        public static LinkList MergeLinkedLists(LinkList ll1, LinkList ll2)
        {
            ll1.Current = ll1.Head;
            ll2.Current = ll2.Head;
            ll1.Runner = ll1.Current;

            while(ll1.Current.Next != null && ll2.Current.Next != null)
            {
                ll1.Runner = ll1.Runner.Next;
                ll1.Current.Next = ll2.Current;
                ll2.Head = ll2.Head.Next;
                ll2.Current.Next = ll1.Runner;
                ll1.Current = ll1.Runner;
                ll2.Current = ll2.Head;
            }

            if(ll1.Current.Next == null && ll2.Current.Next != null)
            {
                ll2.Current = ll2.Head;
                ll1.Current.Next = ll2.Current;
            }
            else if(ll1.Current.Next != null && ll2.Current.Next == null)
            {
                ll1.Runner = ll1.Runner.Next;
                ll1.Current.Next = ll2.Current;
                ll2.Current.Next = ll1.Runner;
            }
            else
            {
                ll1.Current.Next = ll2.Current;
            }
            ll1.Current = ll1.Head.Next;
            return ll1;
        }
        
    }
}
