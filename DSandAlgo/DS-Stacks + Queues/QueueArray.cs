using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Stacks___Queues
{
    public class QueueArray
    {
        //using List<T>"Dynamic Array" instead of array for simplicity 
        List<int> array;
        public QueueArray()
        {
            array = new List<int>();
        }
        //O(n) if you have to resize otherwise O(1)
        public void Enqueue(int value)
        {
            array.Add(value);
        }
        //O(1)
        public int Dequeue()
        {
            int value = array[0];
            array.RemoveAt(0);
            return value;
        }
        //O(1)
        public int Peek()
        {
            return array[0];
        }
        //O(n)
        public void Display()
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        //O(n)
        public void DisplayCount()
        {
            Console.WriteLine("The number of items in the Queue is: " + array.Count);
        }
    }
}
