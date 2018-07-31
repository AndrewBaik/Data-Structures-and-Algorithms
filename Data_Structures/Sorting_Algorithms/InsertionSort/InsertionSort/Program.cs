using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //int[] arr = new int[] { 2, 5, 1, 10, 3 };
            int[] arr = new int[] { 1,2 ,-3,4,5,6,7,8 };

            int[] output = Insertion_Sort(arr);
            foreach(int numb in output)
            {
                Console.WriteLine(numb);
            }
        }

        public static int[] Insertion_Sort(int[] input)
        {
            for(int i = 1; i < input.Length; i++)
            {
                int j = i;
                while( j > 0 && (input[j] < input[j - 1]))
                {
                    int temp = input[j];
                    input[j] = input[j - 1];
                    input[j - 1] = temp;

                    j--;
                }
            }
            return input;
        }
    }
}
