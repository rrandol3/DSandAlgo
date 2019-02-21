using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Linked_Lists
{
    public class Node
    {
        int value;
        Node next;

        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public Node Next
        {
            get { return next; }
            set { this.next = value; }
        }

        public Node(int value, Node next)
        {
            this.value = value;
            this.next = next;
        }


    }
}
