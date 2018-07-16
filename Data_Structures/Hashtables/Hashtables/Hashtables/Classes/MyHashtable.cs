using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    public class MyHashtable
    {
        List<int>[] Arr = new List<int>[1024];


        // Add(key , value)
        public void Add(string key, int value)
        {
            int ind = GetHash(key);

            if (Arr[ind] == null)
            {
                List<int> list = new List<int>();
                list.Add(value);
                Arr[ind] = list;
            }
            else
            {
                Arr[ind].Add(value);
            }
        }


        // Find(key)
        // returns its values
        public List<int> Find(string key)
        {
            int ind = GetHash(key);
            return Arr[ind];
        }


        // Contains(key)
        // returns bool
        public bool Contains(string key)
        {
            int ind = GetHash(key);

            if (Arr[ind] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        // GetHash(key)
        // returns calculated index int
        public int GetHash(string key)
        {
            int ascii = 0;
            for (int i = 0; i < key.Length; i++)
            {
                ascii += key[i];
            }

            Double decIndex = (ascii * 599) / 1024;
            Double index = Math.Floor(decIndex);
            int ind = Convert.ToInt32(index);

            return ind;
        }
    }
}
