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
            Node node = new Node(2, null);
            Node node1 = new Node(4, null);
            Node node2 = new Node(6, null);
            Node node3 = new Node(8, null);
            LinkedList linkedList = new LinkedList(node);
            linkedList.Insert(node1);
            linkedList.Insert(node2);
            linkedList.Insert(node3);
            linkedList.Delete(8);
            linkedList.Display();
        }
    }
}
