using System;

namespace QuickSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 5, 12, 51, 72, 23, 53, 11, 23, 621, 20 };

            Console.WriteLine();
            Console.Write("Given: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            Quick_Sort(arr);

            Console.WriteLine();
            Console.Write("Result: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        public static void Quick_Sort(int[] input)
        {
            Quick_Sort(input, 0, input.Length - 1);
        }

        public static void Quick_Sort(int[] input, int left, int right)
        {
            int l = left;
            int r = right;
            int pivot = input[(left + right) / 2];

            while (l <= r)
            {
                while (input[l] < pivot)
                {
                    l++;
                }
                while (input[r] > pivot)
                {
                    r--;
                }
                if (l <= r)
                {
                    int swap = input[l];
                    input[l] = input[r];
                    input[r] = swap;

                    l++;
                    r--;
                }
            }

            // For visual purpose
            Console.WriteLine();
            foreach (int i in input)
            {
                Console.Write(i + " ");
            }


            if (left < r)
            {
                Quick_Sort(input, left, r);
            }
            if (l < right)
            { 
                Quick_Sort(input, l, right);
            }

        }

    }
}
