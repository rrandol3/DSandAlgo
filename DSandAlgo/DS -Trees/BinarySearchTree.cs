using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS__Trees
{
    public class BinarySearchTree
    {
        BinaryTreeNode root;

        public BinarySearchTree() { }

        public void Insert(int value)
        {
            if (root == null)
            {
                root = new BinaryTreeNode(value);
            }
            else
            {
                BinaryTreeNode temp = root;
                while (temp != null)
                {
                    if (value > temp.Value)
                    {
                        temp.Right = new BinaryTreeNode(value);
                    }
                    else
                    {
                        temp.Left = new BinaryTreeNode(value);
                    }
                }
            }
        }


        public bool LookUp(int value)
        {
            return false;
        }
    }
}
