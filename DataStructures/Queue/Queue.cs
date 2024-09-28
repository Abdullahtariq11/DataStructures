using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataStructures.LinkedList;

namespace DataStructures.Queue
{
    public class Queue
    {
        public Node? Head { get; set; }
        public Node? Tail { get; set;}
        public int Length { get; set; }

        public Queue()
        {
            Head=null;
            Tail=null;
        }

        public void Enqueue(int value)
        {
            Node newNode=new Node(value);
            if(isEmpty())
            {
                this.Head=newNode;
                this.Tail=newNode;
            }
            else
            {
                this.Tail.Next=newNode;
                this.Tail=this.Tail.Next;
                
            }
            Length++;
        }
        public void Dequeue()
        {
            if(isEmpty())
            {
                Console.WriteLine("Queue is empty");
            }
            else if(this.Length==1)
            {
                this.Head=null;
                this.Tail=null;
            }
            else
            {
                this.Head=Head.Next;
            }
            Length--;
        }
        public int Peek()
        {
            if(!isEmpty())
            {
                return Head.Value;
            }
            else return -1;
        }

        public bool isEmpty()
        {
            return Length==0;
        }
    }
}