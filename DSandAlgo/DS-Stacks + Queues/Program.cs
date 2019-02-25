using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Stacks___Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            //StackLL stack = new StackLL();
            //StackLLN stack = new StackLLN();
            //StackArray stack = new StackArray();
            //stack.Push(2);
            //stack.Push(4);
            //stack.Push(6);
            //stack.Push(8);
            //stack.Push(10);
            //stack.Display();
            //stack.DisplayCount();
            //Console.WriteLine("Popping {0} off the top!", stack.Pop());
            //Console.WriteLine("Popping {0} off the top!", stack.Pop());
            //Console.WriteLine("Popping {0} off the top!", stack.Pop());
            //Console.WriteLine("The current Top value is {0}!", stack.Peek());
            //stack.Display();
            //stack.DisplayCount();

            QueueLLN queue = new QueueLLN();
            //QueueArray queue = new QueueArray();
            //QueueStack queue = new QueueStack();
            queue.Enqueue(2);
            queue.Enqueue(4);
            queue.Enqueue(6);
            queue.Enqueue(8);
            queue.Enqueue(10);
            queue.Display();
            queue.DisplayCount();
            Console.WriteLine("Dequeue {0} from the front!", queue.Dequeue());
            Console.WriteLine("Dequeue {0} from the front!", queue.Dequeue());
            Console.WriteLine("Dequeue {0} from the front!", queue.Dequeue());
            queue.Display();
            Console.WriteLine("Next in line is {0}!", queue.Peek());
            queue.DisplayCount();
        }
    }
}
