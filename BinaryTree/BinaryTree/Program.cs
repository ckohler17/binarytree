using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(6);
            tree.Add(5);
            tree.Add(10);
            tree.Add(9);
            tree.Search(9);
        }
    }
}
