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
            //stack.Push(2);
            //stack.Push(4);
            //stack.Push(6);
            //stack.Push(8);
            //stack.Push(10);
            //stack.Display();
            //stack.DisplayCount();
            //Console.WriteLine("Popping {0} off the top!", stack.Pop());
            //stack.Display();
            //stack.DisplayCount();
            //Console.WriteLine("The current Head is: " + stack.Peek());

            StackLLN stack = new StackLLN();
            stack.Push(2);
            stack.Push(4);
            stack.Push(6);
            stack.Push(8);
            stack.Push(10);
            stack.Display();
            stack.DisplayCount();
            Console.WriteLine("Popping {0} off the top!", stack.Pop());
            Console.WriteLine("Popping {0} off the top!", stack.Pop());
            Console.WriteLine("Popping {0} off the top!", stack.Pop());
            Console.WriteLine("The current Top value is {0}!", stack.Peek());
            stack.Display();
            stack.DisplayCount();
        }
    }
}
