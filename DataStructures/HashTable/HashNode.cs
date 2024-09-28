using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructures.HashTable
{
    public class HashNode
    {
        public int Key { get; set; }
        public int Value { get; set; }
        public HashNode? Next { get; set; } //In case of collison
        public HashNode(int key,int value)
        {
            Key=key;
            Value=value;
            Next=null; //initialize when there is collision.
        }
    }
}