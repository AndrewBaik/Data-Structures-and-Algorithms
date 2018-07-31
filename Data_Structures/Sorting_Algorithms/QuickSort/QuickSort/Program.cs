using System;

namespace QuickSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 5, 2, 7, 3, 8, 1, 4, 6 };

            Console.WriteLine();
            Console.Write("Given: ");
            foreach (int i in arr)
            {
                Console.Write(i);
            }

            Quick_Sort(arr, 0, arr.Length - 1);

            Console.WriteLine();
            Console.Write("Result: ");
            foreach (int i in arr)
            {
                Console.Write(i);
            }
        }

        public static void Quick_Sort(int[] input, int low, int high)
        {
            if(low < high)
            {
                int left = low;
                int right = high;
                int pivot = (low + high) / 2;

                // Console WriteLine
                Console.WriteLine();
                Console.WriteLine($"Pivot is {input[pivot]}");

                while(left <= right)
                {

                    while(input[left] < input[pivot])
                    {
                        left++;
                    }
                    while(input[right] > input[pivot])
                    {
                        right--;
                    }

                    if(left <= right)
                    {

                    int temp = input[left];
                    input[left] = input[right];
                    input[right] = temp;

                    left++;
                    right--;
                    }
            
                    // Console Write 
                    // for visual purpose
                    Console.WriteLine();
                    foreach(int i in input)
                    {
                        Console.Write(i);
                    }
                }

                Quick_Sort(input, low, right);
                Quick_Sort(input, left, high);
            }
        }
    }
}
