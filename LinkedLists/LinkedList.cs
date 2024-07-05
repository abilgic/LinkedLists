using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedLists
{
    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
    public class LinkedList
    {
        private Node Head;

        public void Print()
        {
            var current = Head;
            while (current != null)
            {
                Console.Write($"{current.Data} |");
                current = current.Next;
            }

        }

        public void Add(int value)
        {
            if (Head == null)
            {
                Head = new Node(value);
                return;
            }
            var current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            var newnode = new Node(value);

            current.Next = newnode;

        }
        public void Delete(int value)
        {
            if (Head == null)
            {
                return;
            }
            if (Head.Data == value)
            {
                Head = Head.Next;
                return;
            }
            var current = Head;

            while (current.Next != null)
            {
                
                if (current.Next.Data == value)
                {                    
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }

        }
    }
}
