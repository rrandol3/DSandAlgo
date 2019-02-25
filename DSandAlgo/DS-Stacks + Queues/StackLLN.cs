using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DS_Linked_Lists;

namespace DS_Stacks___Queues
{
    //same as StackLL but instead of using the Linked List class we are using jus the Node class
    public class StackLLN
    {
        Node top;
        Node bottom;
        int count;

        public StackLLN()
        { }

        //O(1)
        public void Push(int value)
        {
            Node newNode = new Node(value);
            if (count == 0)
            {
                top = newNode;
                bottom = top;
            }
            else
            {
                Node holder = top;
                top = newNode;
                top.Next = holder;
            }
            count++;
        }

        //O(1)
        public int Pop()
        {
            int headValue = top.Value;
            Node oldhead = top;
            top = oldhead.Next;
            oldhead.Next = null;
            count--;
            return headValue;
        }

        //O(1)
        public int Peek()
        {
            if (count == 0)
            {
                throw new Exception("Stack is empty");
            }
            return top.Value;
        }

        //O(n)
        public void Display()
        {
            Console.WriteLine("The collection consist of:");
            Node temp = top;
            while (temp != null)
            {
                Console.Write(temp.Value + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }

        public void DisplayCount()
        {
            Console.WriteLine("The number of items in the Stack is: " + count);
        }
    }
}
