using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Linked_Lists
{
    public class DoublyLinkedList
    {
        DLLNode head;
        DLLNode tail;
        int count;

        public DoublyLinkedList(int value)
        {
            DLLNode newNode = new DLLNode(value);
            head = newNode;
            tail = head;
            count++;
        }
        //O(1)
        public void InsertAtHead(int value)
        {
            DLLNode newNode = new DLLNode(value);
            DLLNode oldHead = head;
            head = newNode;
            newNode.Next = oldHead;
            oldHead.Previous = newNode;
            count++;
        }
        //O(1)
        public void InsertAtTail(int value)
        {
            DLLNode newNode = new DLLNode(value);
            DLLNode oldTail = tail;
            newNode.Previous = oldTail;
            oldTail.Next = newNode;
            tail = newNode;
            count++;
        }
        //O(n)
        public void InsertAtIndex(int value, int index)
        {
            if (index > count - 1)
            {
                throw new IndexOutOfRangeException();
            }
            DLLNode newNode = new DLLNode(value);
            DLLNode leader = head;
            int i = 0;
            while (leader != null)
            {
                if (index == i)
                {
                    //at the index [1 3 *99* 5 7 9]
                    //want to insert between follower(3) and leader(5)
                    //follower = 3, leader 5, newNode = 99
                    DLLNode follower = leader.Previous;
                    follower.Next = newNode;
                    newNode.Previous = follower;
                    newNode.Next = leader;
                    leader.Previous = newNode;
                    count++;
                }
                leader = leader.Next;
                i++;
            }
        }
        //O(n)
        public void Delete(int value)
        {
            DLLNode temp = head;
            while (temp != null)
            {
                if (temp.Value == value)
                {
                    DLLNode nodeToDelete = temp;
                    DLLNode follower = temp.Previous;
                    DLLNode leader = temp.Next;
                    follower.Next = leader;
                    leader.Previous = follower;
                    nodeToDelete.Previous = null;
                    nodeToDelete.Next = null;
                    count--;
                    return;
                }
                temp = temp.Next;
            }
        }
        //O(n)
        public bool IsPresent(int value)
        {
            DLLNode temp = head;
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
        //O(n)
        public void Display()
        {
            Console.WriteLine("The Doubly Linked List consist of:");
            DLLNode temp = head;
            while (temp != null)
            {
                Console.Write(temp.Value + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }
        public void DisplayCount()
        {
            Console.WriteLine("The number of items in the Doubly Linked List:");
            Console.WriteLine(count);
        }
    }
}
