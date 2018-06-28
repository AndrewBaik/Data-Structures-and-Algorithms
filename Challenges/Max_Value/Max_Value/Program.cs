using System;
using Max_Value.Classes;

namespace Max_Value
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        public static int MaxValue(BinaryTree bt)
        {
            int maxValue = bt.Root.Value;
           
            if(bt.Root.LeftChild != null)
            {
                if(maxValue < bt.PreOrder(bt.Root.LeftChild, maxValue))
                {
                    maxValue = bt.PreOrder(bt.Root.LeftChild, maxValue);
                }
            }
            if(bt.Root.RightChild != null)
            {
                if (maxValue < bt.PreOrder(bt.Root.RightChild, maxValue))
                {
                    maxValue = bt.PreOrder(bt.Root.RightChild, maxValue);
                }
            }
            return maxValue;
        }

    }
}
