using System;

namespace BasicCoding
{
    public class TreeDepthSolution
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            var left = MaxDepth(root.left);
            var right = MaxDepth(root.right);
            return Math.Max(left, right) + 1;
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