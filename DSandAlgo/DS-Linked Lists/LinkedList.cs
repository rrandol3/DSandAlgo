﻿using System;
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
        //O(n)
        public void Delete(int valueToDelete)
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
