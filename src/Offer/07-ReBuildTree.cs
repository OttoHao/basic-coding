namespace BasicCoding
{
    public class ReBuildTreeSolution
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            var preorderEnd = preorder.Length - 1;
            var inorderEnd = inorder.Length - 1;

            return BuildTree(preorder, inorder, 0, preorderEnd, 0, inorderEnd);
        }

        private TreeNode BuildTree(int[] preorder, int[] inorder, int preorderStart, int preorderEnd, int inorderStart, int inorderEnd)
        {
            if (preorderStart > preorderEnd || inorderStart > inorderEnd)
            {
                return null;
            }
            var rootVal = preorder[preorderStart];
            var root = new TreeNode(rootVal);

            var rootValInorderIndex = FindInorderIndex(inorder, rootVal, inorderStart, inorderEnd);
            if (rootValInorderIndex == -1){
                throw new System.Exception("can not rebuild tree");
            }

            var leftLength = rootValInorderIndex - inorderStart;
            var left = BuildTree(preorder, inorder, preorderStart + 1, preorderStart + leftLength, inorderStart, rootValInorderIndex -1);

            var right = BuildTree(preorder, inorder, preorderStart + leftLength + 1, preorderEnd, rootValInorderIndex + 1, inorderEnd);

            root.left = left;
            root.right = right;

            return root;
        }

        private int FindInorderIndex(int[] inorder, int target, int inorderStart, int inorderEnd)
        {
            for (int i = inorderStart; i <= inorderEnd; i++)
            {
                if (inorder[i] == target){
                    return i;
                }
            }

            return -1;
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