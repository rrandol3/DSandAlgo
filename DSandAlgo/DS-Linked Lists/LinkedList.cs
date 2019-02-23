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

        //O(1)
        public void InsertAtTail(int value)
        {
            Node newNode = new Node(value);
            tail.Next = newNode;
            tail = newNode;
            count++;
        }
        //O(1)
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
        //O(n)
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
        //O(1)
        public int RemoveAtHead()
        {
            Node oldHead = head;
            int valueRemoved = oldHead.Value;
            head = oldHead.Next;
            oldHead.Next = null;
            return valueRemoved;
        }
        //O(n)
        public void Remove(int valueToDelete)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.Next.Value == valueToDelete)
                {
                    Node nodeToDelete = temp.Next;
                    temp.Next = nodeToDelete.Next;
                    count--;
                    return;
                }
                temp = temp.Next;
            }

        }
        //O(n) **Need better understanding**
        public void Reverse()
        {
            //[2 4 6 8 10]
            //[10 8 6 4 2]
            Node first = head;
            tail = head;
            Node second = first.Next;
            while (second != null)
            {
                Node temp = second.Next;//6
                second.Next = first;//2
                first = second;//4
                second = temp;//6              
            }
            head.Next = null;
            head = first;
        }

        public int GetHead()
        {
            return head.Value;
        }
        public void Display()
        {
            Console.WriteLine("The collection consist of:");
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
