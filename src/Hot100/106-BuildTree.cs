namespace Hot100
{
    public class BuildTreeFromInAndPostSolution
    {
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            return BuildTree(inorder, postorder, 0, inorder.Length - 1, 0, postorder.Length - 1);
        }

        private TreeNode BuildTree(int[] inorder, int[] postorder, int inorderStart, int inorderEnd, int postorderStart, int postorderEnd)
        {
            if (inorderStart > inorderEnd || postorderStart > postorderEnd) return null;

            var rootVal = postorder[postorderEnd];
            var rootIndex = FindIndex(inorder, rootVal, inorderStart, inorderEnd);

            var leftLength = rootIndex - inorderStart;
            var left = BuildTree(inorder, postorder, inorderStart, rootIndex - 1, postorderStart, postorderStart + leftLength - 1);
            var right = BuildTree(inorder, postorder, rootIndex + 1, inorderEnd, postorderStart + leftLength, postorderEnd - 1);

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