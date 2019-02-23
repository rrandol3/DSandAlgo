using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DS_Linked_Lists;

namespace DS_Stacks___Queues
{
    public class StackLL
    {
        LinkedList data;
        int count;

        public StackLL()
        {
            data = new LinkedList();
        }
        public void Push(int value)
        {
            data.InsertAtHead(value);
            count++;
        }

        public int Pop()
        {
            if (count < 1)
            {
                throw new Exception("The Stack is empty.");
            }
            count--;
            return data.RemoveAtHead();
        }

        public int Peek()
        {
            if (count < 1)
            {
                throw new Exception("The Stack is empty.");
            }
            return data.GetHead();
        }
         

        public void Display()
        {
            data.Display();
        }

        public void DisplayCount()
        {
            Console.WriteLine("The number of items in the Stack is: " + count);
        }
    }
}
