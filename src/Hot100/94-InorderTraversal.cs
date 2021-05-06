using System.Collections.Generic;

namespace Hot100
{
    public class InorderTraversalSolution
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            var ret = new List<int>();

            InorderTraversal(root, ret);
            return ret;
        }

        private void InorderTraversal(TreeNode root, IList<int> ret)
        {
            if (root == null) return;
            InorderTraversal(root.left, ret);
            ret.Add(root.val);
            InorderTraversal(root.right, ret);
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