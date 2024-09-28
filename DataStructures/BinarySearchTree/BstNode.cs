using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataStructures.LinkedList;

namespace DataStructures.BinarySearchTree
{
    public class BstNode
    {
        public int Value { get; set; }
        public BstNode? Right { get; set; }
        public BstNode? Left { get; set; }
        public BstNode(int value)
        {
            this.Value=value;
            this.Right = null;
            this.Left = null;
        }
    }
}