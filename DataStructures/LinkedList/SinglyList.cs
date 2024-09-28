using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    public class SinglyList
    {
        public Node? Head { get; set; }
        public int Length { get; set; }

        public SinglyList()
        {
            this.Head = null;
            this.Length = 0;
        }

        public void InsertFirst(int value)
        {
            Node node = new Node(value);
            if (this.Length == 0)
            {
                this.Head = node;
            }
            else
            {
                node.Next = this.Head;
                this.Head = node;
            }
            this.Length++;
        }
        public void InsertLast(int value)
        {
            Node node = new Node(value);
            if (this.Length == 0)
            {
                this.Head = node;
            }
            else
            {
                Node current = this.Head;
                int tempLength=this.Length - 1;
                while (tempLength>0)
                {
                    current = current.Next;
                    --tempLength;
                }
                current.Next=node;
                
            }
            this.Length++;

        }
        public void InsertAtIndex(int index,int value)
        {
            Node node=new Node(value);
            if (index>this.Length || index<0)
            {
                Console.WriteLine("Index is out of bound");
                throw new ArgumentOutOfRangeException("index");
            }
            else if (index==this.Length)
            {
                InsertLast(value);
            }
            else if (index==0)
            {
                InsertFirst(value);
            }
            else
            {
                Node current=this.Head;
                for (int i=0; i<index-1;i++)
                {
                    current=current.Next;
                }
                Node temp=current;
                node.Next=temp.Next;
                current.Next=node;
                this.Length++;
            }
        }

        public void RemoveAt(int index)
        {
            if (index>=this.Length||index<0)
            {
                throw new ArgumentOutOfRangeException("index", "Index is out of bounds");
            }
            else if(index==0)
            {
                this.Head=this.Head.Next;
                this.Length--;
            }
            else if(index==this.Length-1)
            {
                Node current=this.Head;
                for(int i=0; i<index-1;i++)
                {
                    current=current.Next;
                }
                current.Next=null;
                this.Length--;
            }
            else
            {
                Node current=this.Head;
                for(int i=0; i<index-1;i++)
                {
                    current=current.Next;
                }
                Node temp= current.Next;
                current.Next=temp.Next;
                this.Length--;
            }

        }
        
        public void PrintList()
        {
            Node current = this.Head;
            if (this.Length==0)
            {
                Console.WriteLine("List is empty");
            }
            while (current != null)
            {
                Console.Write(current.Value + (current.Next != null ? " -> " : ""));
                current = current.Next;
            }
        }
    }
}