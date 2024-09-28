using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    public class Node
    {
        public int Value { get; set; }
        public Node? Next { get; set; }
        public Node(int value)
        {
            this.Value = value;
        }

    }
}