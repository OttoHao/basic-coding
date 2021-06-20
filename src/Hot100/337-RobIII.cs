using System;
using System.Linq;

namespace Hot100
{
    public class RobIIISolution
    {
        public int Rob(TreeNode root)
        {
            var v = RobIII(root);
            return v[1];
        }

        private int[] RobIII(TreeNode root)
        {
            if (root == null) return new int[2] { 0, 0 };
            
            var left = RobIII(root.left);
            var right = RobIII(root.right);

            var v0 = left[1] + right[1];
            var v1 = Math.Max(left[0] + right[0] + root.val, v0);
            return new int[2] { v0, v1 };
        }


        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    }
}