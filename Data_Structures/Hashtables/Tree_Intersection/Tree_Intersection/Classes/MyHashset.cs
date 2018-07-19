using System;
using System.Collections.Generic;
using System.Text;

namespace Tree_Intersection.Classes
{
    public class MyHashset
    {
        public int[] Arr = new int[1024];


        // Add(key , value)
        public void Add(string key, int value)
        {
            int ind = GetHash(key);

            if (Arr[ind] == 0)
            {
                Arr[ind] = value;
            }
            else
            {
                Arr[ind].Add(value);
            }
        }

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
