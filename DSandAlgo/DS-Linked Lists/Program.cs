using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Linked_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList(2);
            linkedList.InsertAtTail(4);
            linkedList.InsertAtTail(6);
            linkedList.InsertAtTail(8);
            linkedList.InsertAtHead(12);
            linkedList.InsertAtHead(14);
            linkedList.Display();
            linkedList.DisplayCount();
            Console.WriteLine("Is 14 present? " + linkedList.IsPresent(14));
        }
    }
}
