using System;
using System.Collections.Generic;
using System.Text;

namespace RepeatedWord.Classes
{
    public class MyHashset
    {
        public string[] Arr = new string[1024];

        public int GetHash(string key)
        {
            int value = 0;
            for(int i = 0; i < key.Length; i++)
            {
                value += key[i];
            }

            double index = (value * 599) / 1024;
            double ind = Math.Floor(index);
            return Convert.ToInt32(ind);

        }

        public void Add(string key)
        {
            int index = GetHash(key);
            
            if(Arr[index] == null)
            {
                Arr[index] = key;
            }
        }
    }
}
