using System;
namespace ReverseArray
{
    class reverseArray
    {
        static string Main(string[] args)
        {
            string[] test1 = new string[] { 0, 1, 2, 3, 4};
            string[] test2 = new string[] { 10, 9, 8, 7, 6, 5 };

            ReverseArray(test1);
            ReverseArray(test2);
        }

        private string ReverseArray(string[] myArry)
        {
            string[] reverseArray = new string[myArray.Length];

            int number = 0;

                for (int i = myArray.Length - 1; i >= 0; i--)
                {
                    reverseArray[i] = myArray[number];
                    number++;
                }
            
            return reverseArray;
        }
    }
}