using System;
using System.Collections;
using System.Collections.Generic;

namespace Left_Join
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

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

            List<string[]> result = LeftJoin(hm1, hm2);

            foreach(string[] arr in result)
            {
                Console.WriteLine($"Key: {arr[0]}  -> {arr[1]}  and  {arr[2]}");
            }
        }

        public static List<string[]> LeftJoin(Dictionary<string, string> hm1, Dictionary<string, string> hm2)
        {
            string[] keyvalue = new string[3];
            List<string[]> result = new List<string[]>();
            
            foreach(string key in hm1.Keys)
            {
                result.Add(new string[] {key, hm1[key], null });
            }

            foreach(string key in hm2.Keys)
            {
                if (hm1.ContainsKey(key))
                {
                    foreach(string[] arr in result)
                    {
                        if(arr[0] == key)
                        {
                            arr[2] = hm2[key];
                        }
                    }
                }
            }
            return result;
        }
    }
}
