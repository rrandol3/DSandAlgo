using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS__Trees
{
    public class BinaryTreeNode
    {
        int value;
        BinaryTreeNode left;
        BinaryTreeNode right;

        public BinaryTreeNode Left
        {
            get { return left; }
            set { left = value; }
        }

        public BinaryTreeNode Right
        {
            get { return right; }
            set { right = value; }
        }

        public int Value
        {
            get { return value ; }
            set { this.value = value; }
        }

        public BinaryTreeNode(int value)
        {
            this.value = value;
        }
    }
}
