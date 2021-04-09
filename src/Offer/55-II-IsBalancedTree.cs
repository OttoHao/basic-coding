using System;

namespace BasicCoding
{
    public class IsBalancedTreeSolution
    {
        public bool IsBalanced(TreeNode root)
        {
            return IsBalanced(root, out var any);
        }

        private bool IsBalanced(TreeNode root, out int depth)
        {
            if (root == null)
            {
                depth = 0;
                return true;
            }

            var isLeftBalanced = IsBalanced(root.left, out var leftDepth);
            var isRightBalaned = IsBalanced(root.right, out var rightDepth);

            depth = Math.Max(leftDepth, rightDepth) + 1;
            return Math.Abs(leftDepth - rightDepth) <= 1 && isLeftBalanced && isRightBalaned;
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
    }
}