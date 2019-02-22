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
            //LinkedList linkedList = new LinkedList(2);
            //linkedList.InsertAtTail(4);
            //linkedList.InsertAtTail(6);
            //linkedList.InsertAtTail(8);
            //linkedList.InsertAtHead(12);
            //linkedList.InsertAtHead(14);
            //linkedList.Delete(6);
            //linkedList.Display();
            //linkedList.DisplayCount();
            //Console.WriteLine("Is 14 present? " + linkedList.IsPresent(14));

            Console.WriteLine();
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList(1);
            doublyLinkedList.InsertAtTail(3);
            doublyLinkedList.InsertAtTail(5);
            doublyLinkedList.InsertAtTail(7);
            doublyLinkedList.InsertAtTail(9);
            //doublyLinkedList.InsertAtTail(11);
            //doublyLinkedList.InsertAtTail(13);
            doublyLinkedList.InsertAtIndex(99, 2);
            doublyLinkedList.Delete(100);
            //doublyLinkedList.Delete(11);
            doublyLinkedList.Display();
            doublyLinkedList.DisplayCount();
            Console.WriteLine("Is 13 present? " + doublyLinkedList.IsPresent(13));
        }
    }
}
