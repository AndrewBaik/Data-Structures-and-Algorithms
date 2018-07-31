using System;
using Xunit;
using QuickSort;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestToCheckArrayGetsSorted()
        {
            int[] test1 = { 5, 12, 7, 3, 78, 2, 1 };
            Program.Quick_Sort(test1, 0, test1.Length - 1);
            int[] expect1 = { 1, 2, 3, 5, 7, 12, 78 };

            Assert.Equal(expect1, test1);
        }

        [Fact]
        public void TestToSeeIfNegativeNumbersWork()
        {
            int[] test2 = { 5, 12, -7, 3, -78, -2, 1 };
            Program.Quick_Sort(test2, 0, test2.Length - 1);
            int[] expect2 = { -78, -7, -2 ,1, 3, 5, 12 };

            Assert.Equal(expect2, test2);
        }

        [Fact]
        public void TestForSameIntegers()
        {
            int[] test3 = { 1, 2, 3, 3, 2, 1, 1, 2, 3 };
            Program.Quick_Sort(test3, 0, test3.Length - 1);
            int[] expect3 = { 1, 1, 1, 2, 2, 2, 3, 3, 3};

            Assert.Equal(expect3, test3);
        }
    }
}
