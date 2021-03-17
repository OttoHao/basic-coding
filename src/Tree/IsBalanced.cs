using System;

namespace BasicCoding
{
    public static partial class TreeUtility
    {
        public static bool IsBalanced(TreeNode root)
        {
            return IsBalanced(root, out var depth);
        }
        
        public static bool IsBalanced(TreeNode root, out int depth)
        {
            if (root == null)
            {
                depth = 0;
                return true;
            }


            var leftIsBalanced = IsBalanced(root.Left, out var leftDepth);
            var rightIsBalanced = IsBalanced(root.Right, out var rightDepth);
            var rootIsBalanced = Math.Abs(leftDepth - rightDepth) <= 1;

            depth = Math.Max(leftDepth, rightDepth) + 1;
            return leftIsBalanced && rightIsBalanced && rootIsBalanced;
        }
    }
}