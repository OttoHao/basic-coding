namespace Hot100
{
    public class HasPathSumInTreeSolution
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) return false;
            targetSum -= root.val;

            if (targetSum == 0 && root.left == null && root.right == null) return true;

            if (HasPathSum(root.left, targetSum) || HasPathSum(root.right, targetSum))
            {
                return true;
            }
            else
            {
                targetSum += root.val;
                return false;
            }
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