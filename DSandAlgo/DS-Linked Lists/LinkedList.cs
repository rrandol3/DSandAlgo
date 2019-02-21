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

        public LinkedList(Node head)
        {
            this.head = head;
        }

        public void Insert(Node node)
        {
            if (head == null)
            {
                head = node;
                return;
            }
            Node temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = node;
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
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.Value);
                temp = temp.Next;
            }
        }
    }
}
