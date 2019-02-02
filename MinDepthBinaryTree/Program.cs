using System;

namespace MinDepthBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minimum Depth In A Binary Tree!");
            Console.WriteLine("-------------------------------");

            BinaryTree tree = GetTreeFromInput();
            try
            {
                Console.WriteLine("Minimum depth in the given tree is "+
                    tree.GetMinimumDepth(tree.GetRoot()));
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }


            Console.ReadLine();
        }

        private static BinaryTree GetTreeFromInput() {
            BinaryTree binaryTree = null;

            Console.WriteLine("Enter the number of nodes in the Binary Tree");
            try
            {
                int noNodes = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the elements separated by space");
                String[] elements = Console.ReadLine().Split(' ');
                binaryTree = new BinaryTree();
                for (int i = 0; i < noNodes; i++) {
                    binaryTree.SetRoot(
                        binaryTree.Insert(binaryTree.GetRoot(),
                            int.Parse(elements[i])));
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            return binaryTree;
        }
    }
}
