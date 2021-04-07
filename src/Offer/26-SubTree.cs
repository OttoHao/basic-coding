namespace BasicCoding
{
    public class SubTreeSolution
    {
        public bool IsSubStructure(TreeNode A, TreeNode B)
        {
            if (A == null || B == null)
            {
                return false;
            }

            var root = IsSubTreeFromCurrentNode(A, B);
            var left = IsSubStructure(A.left, B);
            var right = IsSubStructure(A.right, B);

            return root || left || right;
        }

        private bool IsSubTreeFromCurrentNode(TreeNode a, TreeNode b)
        {
            // todo the order makes different
            if (b == null)
            {
                return true;
            }

            if (a == null)
            {
                return false;
            }

            if (a.val != b.val)
            {
                return false;
            }

            return IsSubTreeFromCurrentNode(a.left, b.left) && IsSubTreeFromCurrentNode(a.right, b.right);
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