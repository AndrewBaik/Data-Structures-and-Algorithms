using System;

namespace Program.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test1 = new int[]{0, 1, 2, 3, 4, 5};
            int[] test2 = new int[]{6, 7, 8, 9, 10, 11, 12, 13, 14};
            int[] test3 = new int[]{10, 20, 30, 40, 50, 60, 70};
            int[] test4 = new int[]{4, 8, 15, 16, 23, 42};
            int[] test5 = new int[]{11, 22, 33, 44, 55, 66, 77};

            BinarySearch(test1, 3);
            BinarySearch(test2, 14);
            BinarySearch(test3, 55);
            BinarySearch(test4, 15);
            BinarySearch(test5, 90);
           Console.ReadLine();
        }

        static int BinarySearch(int[] sortedArray, int key)
        {
            for(int i = 0; i < sortedArray.Length; i++)
            {
                if(sortedArray[i] == key)
                {
                    Console.WriteLine("test " + i);
                    return i;
                }
            }
            Console.WriteLine("test: -1");
            return -1;
        }
    }
}
