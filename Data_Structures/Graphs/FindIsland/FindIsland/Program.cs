using System;
using System.Collections.Generic;

namespace FindIsland
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            int[][] island = new int[][]
            {
                new int[] {0, 1, 0, 0, 1, 0, 0},
                new int[] {1, 0, 0, 1, 0, 0, 0},
                new int[] {0, 0, 0, 0, 0, 0, 0},   
                new int[] {0, 1, 0, 0, 0, 0, 0},    
                new int[] {1, 0, 0, 0, 0, 0, 0},    
                new int[] {0, 0, 0, 0, 0, 0, 1},    
                new int[] {0, 0, 0, 0, 0, 1, 0}
            };

            int[][] island2 = new int[][]
            {
                new int[] {0, 1, 0, 0},
                new int[] {1, 0, 1, 1},
                new int[] {0, 1, 0, 0},
                new int[] {0, 1, 0, 0}
            };

            int result = Find_Island(island);
            Console.WriteLine(result);

            int result2 = Find_Island(island2);
            Console.WriteLine(result2);
        }





        public static int Find_Island(int[][] island)
        {
            bool[] visited = new bool[island.Length];
            int totalIsland = 0;

            for(int row = 0; row < island.Length; row++)
            {
                if(visited[row] != true)
                {
                    visited[row] = true;
                    Recursion(island, visited, row);
                    totalIsland += 1;
                }
            }
            return totalIsland;
        }



        public static void Recursion(int[][] island, bool[] visited, int row)
        {
            for(int i = 0; i < island[row].Length; i++)
            {
                if (island[row][i] == 1 && !visited[i])
                {
                    visited[i] = true;
                    Recursion(island, visited, i);
                }
            }
        }



    }
}
