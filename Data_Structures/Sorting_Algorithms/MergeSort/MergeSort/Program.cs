using System;

namespace MergeSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] input = { 3, 1, 20, 4, 2 , -2, 15, -32, -1};

            Console.Write("Given array:  ");
            foreach(int i in input)
            {
                Console.Write(i);
            }

            Merge_Sort(input);

            Console.WriteLine();
            Console.Write("Final result:  ");
            foreach (int i in input)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static void Merge_Sort(int[] input)
        {
            Merge_Sort(input, 0, input.Length - 1);
        }

        public static void Merge_Sort(int[] input, int lowestIndex, int highestIndex)
        {
            if (lowestIndex < highestIndex)
            {
                int midIndex = (lowestIndex + highestIndex) / 2;
                Merge_Sort(input, lowestIndex, midIndex);
                Merge_Sort(input, midIndex + 1, highestIndex);
                Merge(input, lowestIndex, midIndex, highestIndex);
            }
        }


        public static void Merge(int[] input, int low, int middle, int high)
        {
            int left = low;
            int right = middle + 1;
            int[] tmp = new int[(high - low) + 1];
            int tmpIndex = 0;

            while((left <= middle) && (right <= high))
            {
                if (input[left] < input[right])
                {
                    tmp[tmpIndex] = input[left];
                    left++;
                }
                else
                {
                    tmp[tmpIndex] = input[right];
                    right++;
                }
                tmpIndex++;
            }

            while (left <= middle)
            {
                tmp[tmpIndex] = input[left];
                left++;
                tmpIndex++;
            }

            while (right <= high)
            {
                tmp[tmpIndex] = input[right];
                right++;
                tmpIndex++;
            }

            for (int i = 0; i < tmp.Length; i++)
            {
                input[low + i] = tmp[i];
            }

            // Console Writeline
            // for visual purpose
            Console.WriteLine();
            foreach (int i in input)
            {
                Console.Write(i);
            }
        }
    }
}

