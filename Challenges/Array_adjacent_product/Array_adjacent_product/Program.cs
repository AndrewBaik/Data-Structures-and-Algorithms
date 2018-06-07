using System;

namespace Array_adjacent_product
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,] { {1,2,1}, {2,4,2}, {3,6,8}, {7,8,1}};
            //int output = 
                //Adjacentproduct(arr);

            // Console.WriteLine(output);
            //Console.ReadLine();

            int highestProductValue = 0;

            for (int i = 1; i <= arr.GetLength(0) - 2; i++)
            {
                for (int j = 1; j <= arr.GetLength(1) - 2; j++)
                {
                    int productValue = CheckHighestProduct(arr, i, j);
                   
                    if (highestProductValue < productValue)
                    {
                        highestProductValue = productValue;
                    }
                }

            }
            Console.WriteLine(highestProductValue);
            Console.ReadLine();
        }
      
        static int CheckHighestProduct(int[,] arr, int i, int j)
        {
            int highestProduct = 0;
            int productAmount = 0;
            for(int a = i - 1; a <= i + 1; a++)
            {
                for(int e = j - 1; e <= j + 1; e++)
                {
                    if(!((a == i) && (e == j)))
                    {
                       /* Console.WriteLine($"i is {i} and j is {j}");
                        Console.WriteLine(arr[i, j]);
                        Console.WriteLine(arr[a, e]);
                        Console.ReadLine();*/

                        productAmount = arr[i, j] * arr[a, e];

                        if(productAmount > highestProduct)
                        {
                            highestProduct = productAmount;
                        }
                    }                  
                }
            }
            return highestProduct;
        }
    }
}  
