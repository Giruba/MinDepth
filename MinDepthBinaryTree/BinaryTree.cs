using System;
using System.Collections.Generic;
using System.Text;

namespace MinDepthBinaryTree
{
    class BinaryTree
    {
        BinaryTreeNode root;

        public BinaryTree() { }

        public BinaryTree(BinaryTreeNode root) {
            this.root = root;
        }

        public void SetRoot(BinaryTreeNode root) {
            this.root = root;
        }

        public BinaryTreeNode GetRoot() {
            return root;
        }

        public BinaryTreeNode Insert(BinaryTreeNode root, int data) {
            if (root == null) {
                root = new BinaryTreeNode(data);
                return root;
            }
            if (root.GetData() < data)
            {
                root.SetRight(Insert(root.GetRight(), data));
            }
            else {
                root.SetLeft(Insert(root.GetLeft(), data));
            }
            return root;
        }

        public int GetMinimumDepth(BinaryTreeNode root) {
            if (root == null) return 0;

            if (root.GetLeft() == null &&
                root.GetRight() == null) {
                return 1;
            }

            return Math.Min(GetMinimumDepth(root.GetLeft()),
                GetMinimumDepth(root.GetRight())) + 1;
        }
    }
}
