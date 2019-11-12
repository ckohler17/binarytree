using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinarySearchTree
    {
        public Node root;
        public Node currentNode;
        
        

        public BinarySearchTree()
        {
            root = null;
        }

        public void Add(int data)
        {
            Node node = new Node(data);
            if (root == null)
            {
                root = node;
                return;
            }
            currentNode = root;
            while (currentNode != null)
            {
                if (node.data > currentNode.data)
                {
                    if(currentNode.rightChild == null)
                    {
                        currentNode.rightChild = node;
                        return;
                    } else
                    {
                        currentNode = currentNode.rightChild;
                    }                       
                }
                else if (node.data < currentNode.data)
                {
                    if(currentNode.leftChild == null)
                    {
                        currentNode.leftChild = node;
                        return;
                    }
                    else
                    {
                        currentNode = currentNode.leftChild;
                    }                        
                }
            }
        }
        public bool Search(int data)
        {            
            if (root == null)
            {
                return false;
            }
            else
            {
                currentNode = root;
            }
            while(currentNode.data != data)
            {
                if(currentNode == null)
                {
                    return false;
                }
                if (data > currentNode.data)
                {
                    currentNode = currentNode.rightChild;
                }
                else if (data < currentNode.data)
                {
                    currentNode = currentNode.leftChild;
                }
            }
            return true;
        }
    }    
}
