using System;
using Xunit;
using Hashtables;
using Hashtables.Classes;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestForAddingValuesToHash()
        {
            MyHashtable test1 = new MyHashtable();
            test1.Add("test", 1);
            test1.Add("test", 2);
            test1.Add("test", 3);
            test1.Add("test", 4);

            List<int> result = test1.Find("test");
            List<int> expect = new List<int>{1, 2, 3, 4};

            Assert.Equal(expect, result);
        }

        [Fact]
        public void TestForContainMethodOfHash()
        {
            MyHashtable test2 = new MyHashtable();
            test2.Add("test", 1);
            test2.Add("test", 2);
            test2.Add("test2", 3);
            test2.Add("test2", 4);

            Assert.True(test2.Contains("test"));
            Assert.True(test2.Contains("test2"));
            Assert.False(test2.Contains("test1"));
        }

        [Fact]
        public void TestForCollisonOfHashKeys1()
        {
            MyHashtable test3 = new MyHashtable();
            test3.Add("Cat", 1);
            test3.Add("Cat", 2);
            test3.Add("Doe", 3);
            test3.Add("Doe", 4);

            Assert.Equal(163, test3.GetHash("Cat"));
            Assert.Equal(163, test3.GetHash("Doe"));
        }

        [Fact]
        public void TestForCollisionOfHashKeys2()
        {
            MyHashtable test3 = new MyHashtable();
            test3.Add("Cat", 1);
            test3.Add("Cat", 2);
            test3.Add("Doe", 3);
            test3.Add("Doe", 4);

            List<int> catValueList = test3.Find("Cat");
            List<int> doeValueList = test3.Find("Doe");
            List<int> expected = new List<int> { 1, 2, 3, 4 };

            Assert.Equal(expected, catValueList);
            Assert.Equal(expected, doeValueList);
        }
    }
}
