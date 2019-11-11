using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinarySearchTree
    {
        Node root;

        public BinarySearchTree()
        {

        }

        public void Add(int data)
        {
            Node node = new Node(data);
            if(root == null)
            {
                root = node;
                return;
            }
            //if data > current node add node to the right
            //if data < current node add node to the left
        }
        public void Search()
        {

        }
    }
}
