using System;
using Xunit;
using MergeSort;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestForSortedArray1()
        {
            int[] test1 = { 5, 3, 2, 0, 8 };
            Program.Merge_Sort(test1, 0, test1.Length - 1);

            int[] expect = { 0, 2, 3, 5, 8 };
            Assert.Equal(expect, test1);
        }

        [Fact]
        public void TestForSortedArray2()
        {
            int[] test2 = { 7, 2, 9, 3, 5, 1, 4};
            Program.Merge_Sort(test2, 0, test2.Length - 1);

            int[] expect = { 1, 2, 3, 4, 5, 7, 9 };
            Assert.Equal(expect, test2);
        }

        [Fact]
        public void TestForSortedArrayUsingNegativeInt()
        {
            int[] test3 = { 0, 1, 2, 3, 4, -5, 6, 7, 8, -9, 0};
            Program.Merge_Sort(test3, 0, test3.Length - 1);

            int[] expect = { -9, -5, 0, 0 , 1, 2, 3, 4, 6, 7, 8};
            Assert.Equal(expect, test3);
        }
    }
}
