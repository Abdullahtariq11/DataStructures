using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructures.Stack
{
    public class Stack<T>
    {
        public T[]? stack { get; set; }
        public int Pointer { get; set; }

        public Stack(int size)
        {
            stack=new T[size];
            Pointer=0;
        }
        public void Push(T item)
        {
            if(Pointer==stack.Length) // check if the stack is full
            {
                Console.WriteLine("Stack overflow!");
                return;
            }
            stack[Pointer] =item;
            Pointer++;
        }
        public T Pop()
        {
            if (isEmpty())
            {
                Console.Write("Stack is empty");
                return default(T);
            }
            T value = stack[Pointer-1];
            --Pointer;
            return value;
        }
        public T Peek()
        {
            if (isEmpty())
            {
                Console.Write("Stack is empty");
                return default(T);
            }
            
            return stack[Pointer-1];
        }
        public bool isEmpty()
        {
            return Pointer == 0;
        }
    }
}