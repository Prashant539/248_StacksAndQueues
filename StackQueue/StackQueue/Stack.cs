﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    public class Stack
    {
        public Node top;
        public Stack()
        {
            this.top = null;

        }
        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.top != null)
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to Stack", value);
        }
        internal void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
