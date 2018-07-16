using System;
using System.Collections;
using System.Collections.Generic;
using Hashtables.Classes;

namespace Hashtables
{
    class Program
    {
        static void Main(string[] args)
        {
            MyHashtable ht = new MyHashtable();
            ht.Add("one", 5);
            Console.WriteLine("Added => Key: one, value: 5 ");

            ht.Add("one", 15);
            Console.WriteLine("Added => Key: one, value: 15 ");

            ht.Add("two", 10);
            Console.WriteLine("Added => Key: two, value: 10 ");
            Console.WriteLine();

            List<int> valueList = ht.Find("one");

            Console.WriteLine("Key of 'one' contains following values: ");
            foreach(int val in valueList)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine();
            bool contain = ht.Contains("one");
            bool contains = ht.Contains("One");
            Console.WriteLine();
            Console.WriteLine("Hastable contains a key of 'one': " + contain);
            Console.WriteLine("Hastable contains a key of 'One': " + contains);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Collision test of 'Cat' and 'Doe' : ");
            Console.WriteLine();

            MyHashtable colsn = new MyHashtable();

            colsn.Add("Cat", 50);
            Console.WriteLine("Added => Key: Cat, value: 50 ");
            colsn.Add("Doe", 100);
            Console.WriteLine("Added => Key: Doe, value: 100 ");

            List<int> catList = colsn.Find("Cat");
            List<int> doeList = colsn.Find("Doe");

            Console.WriteLine("Key: Cat holds following value(s): ");
            foreach(int i in catList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("Key: Doe holds following value(s);");
            foreach (int i in doeList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            bool containCat = colsn.Contains("Cat");
            bool containDoe = colsn.Contains("Doe");
            Console.WriteLine();
            Console.WriteLine("Hastable contains a key of 'Cat': " + containCat);
            Console.WriteLine("Hastable contains a key of 'Doe': " + containDoe);

        }
    }
}
