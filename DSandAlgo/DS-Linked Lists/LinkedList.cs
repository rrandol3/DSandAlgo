using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Linked_Lists
{
    public class LinkedList
    {
        Node head;
        Node tail;
        int count;

        public LinkedList(int value)
        {
            head = new Node(value);
            tail = head;
            count++;
        }

        public void InsertAtTail(int value)
        {
            Node newNode = new Node(value);
            tail.Next = newNode;
            tail = newNode;
            count++;
        }

        public void InsertAtHead(int value)
        {
            Node newNode = new Node(value);
            //temp = head
            //head = newNode
            //newNode.Next = temp;
            Node temp = head;
            head = newNode;
            newNode.Next = temp;
            count++;
        }

        public bool IsPresent(int value)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.Value == value)
                {
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }

        public void Delete(int valueToDelete)
        {
            //find Node before the one you want to delete
            //make before Node.Next point to delete Node.Next
            //make delete Node.Next null
            Node temp = head;
            while (temp.Next != null)
            {
                if (temp.Next.Value == valueToDelete)
                {
                    var nodeToDelete = temp.Next;
                    temp.Next = nodeToDelete.Next;
                    nodeToDelete.Next = null;
                }
                temp = temp.Next;
            }

        }

        public void Display()
        {
            Console.WriteLine("The Linked List consist of:");
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.Value + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }
        public void DisplayCount()
        {
            Console.WriteLine("The number of items in the Linked List:");
            Console.WriteLine(count);
        }

    }
}
