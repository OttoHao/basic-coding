namespace Hot100
{
    public class FlattenTreeToLinkedListSolution
    {
        private TreeNode _pre;
        public void Flatten(TreeNode root)
        {
            _pre = null;
            Inorder(root);
        }

        public void Inorder(TreeNode root)
        {
            if (root == null) return;

            if (_pre != null)
            {
                _pre.left = null;
                _pre.right = root;
            }

            _pre = root;

            var left = root.left;
            var right = root.right;
            
            Inorder(left);
            Inorder(right);
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