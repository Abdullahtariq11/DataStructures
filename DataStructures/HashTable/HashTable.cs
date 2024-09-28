using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructures.HashTable
{
    public class HashTable
    {
        public HashNode[]? Bucket { get; set; }
        public int Capacity { get; set; }

        public HashTable(int capacity)
        {
            this.Capacity = capacity;
            this.Bucket = new HashNode[capacity];
        }
        private int HashFunction(int key)
        {
            return key % Capacity;
        }
        public void Insert(int key, int value)
        {
            int hashedKey = HashFunction(key);
            HashNode head = this.Bucket[hashedKey];
            if (head != null)
            {
                while (head.Next != null)
                {
                    head = head.Next;
                }
                head.Next = new HashNode(key, value);
                return;
            }

            this.Bucket[hashedKey] = new HashNode(key, value); // Make sure original array stores the value instead of saving it in local head.
        }

        public int Get(int key)
        {
            int hashedKey = HashFunction(key);
            HashNode head = this.Bucket[hashedKey];
            while (head != null)
            {

                if (head.Key == key)
                {
                    return head.Value;
                }
                head = head.Next;
            }
            return -1;
        }

        public void Remove(int key)
        {
            int hashedKey = HashFunction(key);
            HashNode head = this.Bucket[hashedKey];

            if(head == null) // check if head exists at this hashed value
            {
                throw new ArgumentException("No value exist at this key value");
            }
            
            else if (head.Next == null && head.Key == key) // If only one node exists
            {
                this.Bucket[hashedKey] = null;
                return;
            }
            else if (head.Key == key) // If the first value matches 
            {
                this.Bucket[hashedKey]= head.Next;
                return;
            }
            while (head.Next != null) // If other index except for first
            {
                if (head.Next.Key == key)
                {
                    HashNode temp = head.Next;
                    head.Next = temp.Next;
                    return;
                }
                head = head.Next;
            }

            throw new ArgumentException("No value exist at this key value");
        }

        public bool ContainsKey(int key)
        {
            int hashedKey= HashFunction(key);
            HashNode head= this.Bucket[hashedKey];
            if (head == null)
            {
                return false;
            }
            while(head != null)
            {
                if(head.Key == key)
                {
                    return true;
                }
                head=head.Next;
            }
            return false;
        }

    }
}