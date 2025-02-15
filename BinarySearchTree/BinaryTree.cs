using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree(Node root)
        {
            Root = root;
        }

        public void Print()
        {
            Print(Root, 0);
        }

        private const int Distance = 10;
        private void Print(Node root, int space)
        {
            if (root == null)
            {
                return;
            }

            space += Distance;
            Print(root.Right, space);
            Console.Write("\n");
            for (int i = Distance; i < space; i++)
            {
                Console.Write(" ");               
            }
            Console.Write($"{root.Value} \n");
            Print(root.Left, space);
        }

        public bool IfNodeExists(Node node, int val)
        {
            if (node == null)
            {
                return false;
            }
            if (node.Value == val)
            {
                return true;
            }

            if (IfNodeExists(node.Left, val))
            {
                return true;
            }

            return IfNodeExists(node.Right, val);
        }

        public void Insert(int val)
        {
            Insert(Root, val);
        }

        private Node Insert(Node node, int val)
        {
            if (node == null)
            {
                return new Node(val);
            }

            if (val < node.Value)
            {
                node.Left = Insert(node.Left, val);
            }
            else
            {
                node.Right = Insert(node.Right, val);
            }

            return node;
        }
    }
}
