using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Stacks___Queues
{
    public class StackArray
    {
        List<int> array;
        public StackArray()
        {
            array = new List<int>();
        }

        //O(n) if size is increased otherwise O(1)
        public void Push(int value)
        {
            array.Add(value);
        }

        //O(1)
        public int Pop()
        {
            int value = array.LastOrDefault();
            array.Remove(array.Last());
            return value;
        }
        //O(1)
        public int Peek()
        {
            return array.LastOrDefault();
        }
        //O(n)
        public void Display()
        {
            Console.WriteLine("The collection consist of:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        //O(1)
        public void DisplayCount()
        {
            Console.WriteLine("The number of items in the Stack is: " + array.Count);
        }
    }
}
