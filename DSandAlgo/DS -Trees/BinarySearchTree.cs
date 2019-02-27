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
        //O(logN)
        public void Insert(int value)
        {
            BinaryTreeNode newNode = new BinaryTreeNode(value);//creation on newNode
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                BinaryTreeNode current = root;
                while (true)//keep looping until we find somewhere to insert item
                {
                    if (value < current.Value)//go to left?
                    {
                        if (current.Left == null)//check if current.Left is null
                        {
                            current.Left = newNode;//if null assign newNode to current.Left
                            return;//exit function
                        }
                        current = current.Left;//set current to current.Left because current.Left has a value already
                    }
                    else //or go to right?
                    {
                        if (current.Right == null)//check if current.Right is null
                        {
                            current.Right = newNode;//if null assign newNode to current.Right
                            return;//exit function
                        }
                        current = current.Right;//set current to current.Right because current.Right has a value already
                    }
                }
            }
        }
        //Need to complete 
        public void Remove(int value)
        {
            if (root == null)
            {
                return;
            }
            BinaryTreeNode current = root;
            BinaryTreeNode parent = null;
            while (current != null)
            {
                if (value < current.Value)
                {
                    parent = current;
                    current = current.Left;
                }
                else if (value > current.Value)
                {
                    parent = current;
                    current = current.Right;
                }
                else if (value == current.Value)
                {
                    if (current.Right == null)
                    {
                        if (parent == null)
                        {
                            root = current.Left;
                        }
                        else
                        {
                            if (current.Value < parent.Value)
                            {
                                parent.Left = current.Left;
                            }
                            else if (current.Value > parent.Value)
                            {
                                parent.Right = current.Left;
                            }
                        }
                    }
                }
                else if (true)
                {

                }
            }
        }
        //O(logN)
        public bool IsPresent(int value)
        {
            if (root == null)
            {
                return false;
            }
            BinaryTreeNode current = root;
            while (current != null)//loop until current is null or value is found
            {
                if (value < current.Value)//if less 
                {
                    current = current.Left;//go to the left 
                }
                else if (value > current.Value)//if greater
                {
                    current = current.Right;//got to right
                }
                else if (value == current.Value)//if value found
                {
                    return true;//return true
                }
            }
            return false;//else return false
        }
        //O(n)
        public void DisplayInorder()
        {
            Console.WriteLine("Inorder:");
            Inorder(root);
        }
        //O(n)
        public void DisplayPreorder()
        {
            Console.WriteLine("Preorder:");
            Preorder(root);
        }
        //O(n)
        public void DisplayPostorder()
        {
            Console.WriteLine("Postorder:");
            Postorder(root);
        }
        //O(n)
        private void Inorder(BinaryTreeNode node)//left, root, right
        {
            if (node != null)
            {
                Inorder(node.Left);
                Console.WriteLine(node.Value);
                Inorder(node.Right);
            }
        }
        //O(n)
        private void Preorder(BinaryTreeNode node)//root, left, right
        {
            if (node != null)
            {
                Console.WriteLine(node.Value);
                Preorder(node.Left);
                Preorder(node.Right);
            }
        }
        //O(n)
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
