using System;
using System.Collections;
using System.Collections.Generic;

namespace RadixSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 149, 3, 68, 1, 423, 51, 102, 11, 164 };

            Console.WriteLine("Given Array: ");
            foreach(int i in array)
            {
                Console.Write(i + " ");
            }

            Radix_Sort(array);


            Console.WriteLine();
            Console.Write("Result: ");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

        }

        public static void Radix_Sort(int[] input)
        {
            // Creates the bucket (list of queues) and 
            // fill it with smaller buckets (queue)
            List<Queue<int>> q = new List<Queue<int>>();
            for(var i = 0; i < 10; i++)
            {
                Queue<int> queue = new Queue<int>();
                q.Add(queue);
            }



            int counter = 0;
            bool stop = false;

            while (!stop)
            {
                stop = true;
                foreach (int value in input)
                {
                    int bucketNumber = (value / (int)Math.Pow(10, counter)) % 10;
                    if (bucketNumber > 0)
                    {
                        stop = false;
                    }
                    q[bucketNumber].Enqueue(value);
                }
                counter++;

                int index = 0;
                foreach (Queue<int> bucket in q)
                {
                    while (bucket.Count > 0)
                    {
                        input[index] = bucket.Dequeue();
                        index++;
                    }
                }

                // for visual purpose
                Console.WriteLine();
                foreach(int value in input)
                {
                    Console.Write(value + " ");
                }

            }

        }
    }
}
