using System;

namespace Hot100
{
    public class IsValidBSTSolution
    {
        private TreeNode _pre = null;
        private bool _ret = true;
        public bool IsValidBST(TreeNode root)
        {
            _pre = null;
            _ret = true;
            Inorder(root);
            return _ret;
        }

        private void Inorder(TreeNode root)
        {
            if (root == null) return;

            Inorder(root.left);

            if (root.val <= _pre?.val)
            {
                _ret = false;
                return;
            }
            _pre = root;

            Inorder(root.right);
        }

        private bool IsValidBST(TreeNode root, long min, long max)
        {
            if (root == null)
            {
                return true;
            }

            if (root.val <= min || root.val >= max)
            {
                return false;
            }

            return IsValidBST(root.left, min, root.val) && IsValidBST(root.right, root.val, max);
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