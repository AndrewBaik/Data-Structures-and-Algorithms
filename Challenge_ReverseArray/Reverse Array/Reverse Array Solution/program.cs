using System;
namespace ReverseArray
{
    class ReverseArray
    {
        static string Main(string[] args)
        {
            string myArray;
            string reverseArray = new string[myArray.Length];

            for(var i = 0; i < myArray.Length; i++)
            {
                for(var e = myArray.Length - 1; i >= 0; i--)
                {
                    reverseArray[e] = myArray[i];
                }
            }
            return reverseArray;
        }
    }
}