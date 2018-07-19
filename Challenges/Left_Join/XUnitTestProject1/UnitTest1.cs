using System;
using Xunit;
using Left_Join;
using System.Collections;
using System.Collections.Generic;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestingForReturningStringArray()
        {
            Dictionary<string, string> hm1 = new Dictionary<string, string>();
            hm1.Add("fond", "enamored");
            hm1.Add("wrath", "anger");
            hm1.Add("dilligent", "employed");
            hm1.Add("outift", "garb");
            hm1.Add("guide", "usher");

            Dictionary<string, string> hm2 = new Dictionary<string, string>();
            hm2.Add("fond", "averse");
            hm2.Add("wrath", "delight");
            hm2.Add("dilligent", "idel");
            hm2.Add("guide", "follow");
            hm2.Add("flow", "jam");

            List<string[]> result = Program.LeftJoin(hm1, hm2);
            string[] expected1 = new string[] { "fond", "enamored", "averse" };
            string[] expected2 = new string[] { "wrath", "anger", "delight" };
            string[] expected3 = new string[] { "dilligent", "employed", "idel" };
            string[] expected4 = new string[] { "guide", "usher", "follow" };
            string[] expected5 = new string[] { "outift", "garb", null };

            Assert.Contains(expected1, result);
            Assert.Contains(expected2, result);
            Assert.Contains(expected3, result);
            Assert.Contains(expected4, result);
            Assert.Contains(expected5, result);
        }
    }
}
