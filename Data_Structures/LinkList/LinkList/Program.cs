using System;
using LinkList.Classes;


namespace LinkList
{
    public class Program
    {
        public Node Current { get; set; }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TestLinkedList();
        }

        static void TestLinkedList()
        {
            LinkdList ll = new LinkdList(new Node(10));

            ll.Add(new Node(15));
            ll.Add(new Node(20));

            ll.Print();

            Console.WriteLine("Lets find ");

        }
    }
}
