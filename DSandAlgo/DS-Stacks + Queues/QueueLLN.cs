using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DS_Linked_Lists;

namespace DS_Stacks___Queues
{
    public class QueueLLN
    {
        Node front;
        Node back;
        int count;

        public QueueLLN() { }
        //O(1)
        public void Enqueue(int value)
        {
            Node newNode = new Node(value);
            if (count == 0)
            {
                front = newNode;
                back = front;
            }
            else
            {
                Node oldBack = back;
                oldBack.Next = newNode;
                back = newNode;
            }
            count++;
        }
        //O(1)
        public int Dequeue()
        {
            int value = front.Value;
            Node oldFront = front;
            front = front.Next;
            oldFront.Next = null;
            count--;
            return value;
        }
        //O(1)
        public int Peek()
        {
            return front.Value;
        }

        //O(n)
        public void Display()
        {
            Console.WriteLine("The collection consist of:");
            Node temp = front;
            while (temp != null)
            {
                Console.Write(temp.Value + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }

        public void DisplayCount()
        {
            Console.WriteLine("The number of items in the Queue is: " + count);
        }
    }
}
