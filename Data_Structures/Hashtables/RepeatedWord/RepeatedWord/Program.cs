using RepeatedWord.Classes;
using System;

namespace RepeatedWord
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string q1 = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York";

            string answer = Repeated_Word(q1);
            Console.WriteLine(answer);
        }

        public static string Repeated_Word(string input)
        {
            string[] inputArr = input.Split(" ");
            MyHashset hs = new MyHashset();

            for(int i = 0; i < inputArr.Length; i++)
            {
                int index = hs.GetHash(inputArr[i]);
    
                if(hs.Arr[index] == null)
                {
                    hs.Add(inputArr[i]);
                }
                else
                {
                    return inputArr[i];
                }
            }
                return "No Repeated word found";
        }
    }
}
