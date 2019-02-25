using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Stacks___Queues
{

    //**Revisit**
    public class QueueStack
    {
        StackLLN stack1;
        StackLLN stack2;
        public int Count { get; set; }
        public QueueStack()
        {
            stack1 = new StackLLN();
            stack2 = new StackLLN();
        }

        //O(n) if you have to resize otherwise O(1)
        public void Enqueue(int value)
        {
            stack1.Push(value);
            Count++;
        }
        //O(1)
        public int Dequeue()
        {
            int value;
            while (stack1.Count != 0)
            {
                value = stack1.Pop();
                stack2.Push(value);
            }
            Count--;
            return stack2.Pop();
        }
        //O(1)
        public int Peek()
        {
            return stack2.Peek();
        }
        //O(n)
        public void Display()
        {
            stack1.Display();
        }
        //O(n)
        public void DisplayCount()
        {
            Console.WriteLine("The number of items in the collection is: " + Count);
        }
    }
}
