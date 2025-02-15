namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(8);

            BinaryTree tree = new BinaryTree(root);
            tree.Root.Left = new Node(3);
            tree.Root.Left.Left = new Node(1);
            tree.Root.Left.Right = new Node(6);
            tree.Root.Left.Right.Left = new Node(4);
            tree.Root.Left.Right.Right = new Node(7);
            tree.Root.Right = new Node(10);
            tree.Root.Right.Right = new Node(14);
            tree.Root.Right.Right.Left = new Node(13);

            tree.Insert(11);

            tree.Print();
            Console.WriteLine(tree.IfNodeExists(tree.Root, 8));
        }
    }
}
