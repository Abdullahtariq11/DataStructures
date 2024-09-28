using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructures.BinarySearchTree
{
    public class BinarySearchTree
    {
        public BstNode? Root { get; set; }
        public BinarySearchTree()
        {
            this.Root = null;
        }

        public void Insert(int value)
        {
            if (this.Root == null)  //check if the root is empty
            {
                Root=new BstNode(value);
                return;
            }
            BstNode current=this.Root;
            BstNode prev=current;
            while (current != null) // check unless empty node is found
            {   prev=current; 
                current=value>current.Value? current.Right:current.Left; //if greater , move to right othervise move to less
                if(value == prev.Value) // avoid duplication
                {
                    return;
                }
            }
            if (value>prev.Value)
            {
                prev.Right=new BstNode(value);
                
            }
            else if(value<prev.Value)
            {
                prev.Left=new BstNode(value);
            }
        }

        public void Remove(int value)
        {
            if(this.Root == null)
            {
                Console.Write("Root is empty");
                return;
            }
            BstNode current= this.Root;
            BstNode prev= current;
            while(current!=null)
            {
                if(value == current.Value)
                {
                    break;
                }
                prev=current;
                current=value>current.Value? current.Right:current.Left;
            }

            if(current.Left==null&&current.Right==null && value==current.Value) //if no children
            {
                if (value>prev.Value)
                {
                    prev.Right=null;
                }
                else
                {
                    prev.Left=null;
                }
                return;
            }
            else if(current.Left==null||current.Right==null && value==current.Value) //if there is one child
            {
                BstNode child=current.Left!=null? current.Left:current.Right;
                if(value>prev.Value)
                {
                    prev.Right=child;
                }
                else
                {
                    prev.Left=child;
                }
            }
            else if(value==current.Value) // if there are both chilldren
            {
                BstNode Parent=current;
                BstNode successor=current.Right;
                while(successor.Left!=null)
                {
                    Parent=successor;
                    successor=successor.Left;
                }
                current.Value=successor.Value;
                if(Parent.Left==successor) // check if the left most have a child
                {
                    Parent.Left=successor.Right;
                }
                else
                {
                    
                    Parent.Right=successor.Right;
                }

            }
        }
    }
}