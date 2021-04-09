namespace BasicCoding
{
    public class KthLargestInBinaryTreeSolution
    {
        private int _result = 0;
        private int _k = 0;
        public int KthLargest(TreeNode root, int k)
        {
            _k = k;
            ReverseInorder(root);
            return _result;
        }

        public void ReverseInorder(TreeNode root)
        {
            if (_k < 0) return;
            if (root == null) return;
            ReverseInorder(root.right);
            _k--;
            if (_k == 0)
            {
                _result = root.val;
                return;
            }
            ReverseInorder(root.left);
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