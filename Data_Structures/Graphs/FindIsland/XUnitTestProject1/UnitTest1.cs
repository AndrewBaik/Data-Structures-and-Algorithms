using System;
using Xunit;
using FindIsland;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestingForReturnForCorrectInteger()
        {
            int[][] testArr1 = new int[][]
            {
                new int[] {0, 1, 0, 0},
                new int[] {1, 0, 0, 1},
                new int[] {0, 0, 0, 1},
                new int[] {0, 1, 1, 0}
            };

            int[][] testArr2 = new int[][]
            {
                new int[] {0, 0, 1, 1},
                new int[] {0, 0, 0, 0},
                new int[] {1, 0, 0, 0},
                new int[] {1, 0, 0, 0}
            };

            int[][] testArr3 = new int[][]
            {
                new int[] {0, 0, 0, 0},
                new int[] {0, 0, 0, 1},
                new int[] {0, 0, 0, 0},
                new int[] {0, 1, 0, 0}
            };

            int[][] testArr4 = new int[][]
            {
                new int[] {0, 0, 0, 0},
                new int[] {0, 0, 0, 0},
                new int[] {0, 0, 0, 0},
                new int[] {0, 0, 0, 0}
            };

            Assert.Equal(1, Program.Find_Island(testArr1));
            Assert.Equal(2, Program.Find_Island(testArr2));
            Assert.Equal(3, Program.Find_Island(testArr3));
            Assert.Equal(4, Program.Find_Island(testArr4));
        }
    }
}
    