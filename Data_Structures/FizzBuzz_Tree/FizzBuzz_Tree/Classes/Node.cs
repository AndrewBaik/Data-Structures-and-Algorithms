﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz_Tree.Classes
{
    public class Node
    {
        public int Value { get; set; }
        public string NewValue { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
    }
}
