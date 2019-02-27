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
            BinaryTreeNode newNode = new BinaryTreeNode(value);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                BinaryTreeNode current = root;
                BinaryTreeNode parent;
                while (true)
                {
                    parent = current;
                    if (value < current.Value)//got left?
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            return;
                        }
                    }
                    else //or go right?
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            return;
                        }
                    }
                }
            }
        }

        public bool LookUp(int value)
        {
            return false;
        }

        public void DisplayInorder()
        {
            Console.WriteLine("Inorder:");
            Inorder(root);
        }

        public void DisplayPreorder()
        {
            Console.WriteLine("Preorder:");
            Preorder(root);
        }

        public void DisplayPostorder()
        {
            Console.WriteLine("Postorder:");
            Postorder(root);
        }

        private void Inorder(BinaryTreeNode node)//left, root, right
        {
            if (node != null)
            {
                Inorder(node.Left);
                Console.WriteLine(node.Value);
                Inorder(node.Right);
            }
        }

        private void Preorder(BinaryTreeNode node)//root, left, right
        {
            if (node != null)
            {
                Console.WriteLine(node.Value);
                Preorder(node.Left);
                Preorder(node.Right);
            }
        }

        private void Postorder(BinaryTreeNode node)//left, right, root
        {
            if (node != null)
            {
                Postorder(node.Left);
                Postorder(node.Right);
                Console.WriteLine(node.Value);
            }
        }
    }
}
