namespace Hot100
{
    public class BuildTreeFromPreAndInSolution
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            return BuildTree(preorder, inorder, 0, preorder.Length - 1, 0, inorder.Length - 1);
        }

        private TreeNode BuildTree(int[] preorder, int[] inorder, int preorderStart, int preorderEnd, int inorderStart, int inorderEnd)
        {
            if (inorderStart > inorderEnd || preorderStart > preorderEnd) return null;

            var rootVal = preorder[preorderStart];
            var rootIndex = FindIndex(inorder, rootVal, inorderStart, inorderEnd);

            var leftLength = rootIndex - inorderStart;
            var left = BuildTree(preorder, inorder, preorderStart + 1, preorderStart + leftLength, inorderStart, rootIndex - 1);
            var right = BuildTree(preorder, inorder, preorderStart + leftLength + 1, preorderEnd, rootIndex + 1, inorderEnd);

            var root = new TreeNode(rootVal, left, right);
            return root;
        }

        private int FindIndex(int[] inorder, int rootVal, int inorderStart, int inorderEnd)
        {
            for (int i = inorderStart; i <= inorderEnd; i++)
            {
                if (rootVal == inorder[i]) return i;
            }
            return -1;
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