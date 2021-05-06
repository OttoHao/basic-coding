using System;

namespace Hot100
{
    public class MaxPathSumSolution
    {
        public int MaxPathSum(TreeNode root)
        {
            return Postorder(root)[0];
        }

        private int[] Postorder(TreeNode root)
        {
            if (root == null) return new int[2] { int.MinValue, int.MinValue };
            

            var left = Postorder(root.left);
            var right = Postorder(root.right);

            var maxFromRoot = root.val;
            maxFromRoot += Math.Max(0, Math.Max(left[1], right[1]));

            var maxThruRoot = root.val;
            maxThruRoot += Math.Max(0, left[1]);
            maxThruRoot += Math.Max(0, right[1]);
            var max = Math.Max(maxThruRoot, Math.Max(left[0], right[0]));
            return new int[2] { max, maxFromRoot };
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