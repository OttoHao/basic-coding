using System;

namespace BasicCoding
{
    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(int value, TreeNode left = null, TreeNode right = null)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }

    public static partial class TreeUtility
    {

        public static TreeNode GenerateTree(int[] nums, int index, int length)
        {
            var leftIndex = 2 * index + 1;
            TreeNode left = null;
            if (leftIndex < length)
            {
                left = GenerateTree(nums, leftIndex, length);
            }

            var rightIndex = 2 * index + 2;
            TreeNode right = null;
            if (rightIndex < length)
            {
                right = GenerateTree(nums, rightIndex, length);
            }
            var node = new TreeNode(nums[index], left, right);
            return node;
        }
        
        public static void InsertLeft(int value, TreeNode node)
        {
            var newNode = new TreeNode(value);
            newNode.Left = node.Left;
            node.Left = newNode;
        }
        public static void InsertRight(int value, TreeNode node)
        {
            var newNode = new TreeNode(value);
            newNode.Right = node.Right;
            node.Right = newNode;
        }

        public static void PreOrderTranverse(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Console.WriteLine(root.Value);
            PreOrderTranverse(root.Left);
            PreOrderTranverse(root.Right);
        }

        public static void PostOrderTranverse(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            PostOrderTranverse(root.Left);
            PostOrderTranverse(root.Right);
            Console.WriteLine(root.Value);
        }

        public static void InOrderTranverse(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            InOrderTranverse(root.Left);
            Console.WriteLine(root.Value);
            InOrderTranverse(root.Right);
        }
    }
}