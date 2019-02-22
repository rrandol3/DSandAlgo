using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Linked_Lists
{
    public class DLLNode
    {
        int value;
        DLLNode next;
        DLLNode previous;

        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public DLLNode Next
        {
            get { return next; }
            set { next = value; }
        }

        public DLLNode Previous
        {
            get { return previous; }
            set { previous = value; }
        }

        public DLLNode(int value)
        {
            this.value = value;
        }
    }
}
