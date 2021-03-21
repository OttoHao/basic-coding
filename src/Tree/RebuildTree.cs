namespace BasicCoding
{
    public class RebuildTreeSolution
    {
        public TreeNode RebuildTree(int[] preOrder, int[] inOrder)
        {
            return RebuildTree(preOrder, inOrder, 0, preOrder.Length - 1, 0, inOrder.Length - 1);
        }
        public TreeNode RebuildTree(int[] preOrder, int[] inOrder, int preOrderStart, int preOrderEnd, int inOrderStart, int inOrderEnd)
        {
            if (preOrderStart > preOrderEnd)
            {
                return null;
            }
            var root = new TreeNode(preOrder[preOrderStart]);

            var inOrderRoot = FindInOrderRootIndex(inOrder, preOrder[preOrderStart], inOrderStart, inOrderEnd);
            if (inOrderRoot == -1)
            {
                throw new System.Exception("can not rebuild");
            }

            var leftLength = inOrderRoot - inOrderStart;
            var left = RebuildTree(preOrder, inOrder, preOrderStart + 1, preOrderStart + leftLength, inOrderStart, inOrderRoot - 1);
            var rightLength = inOrderEnd - inOrderRoot;
            var right = RebuildTree(preOrder, inOrder, preOrderStart + leftLength + 1, preOrderEnd, inOrderRoot + 1, inOrderEnd);
            root.Left = left;
            root.Right = right;
            return root;
        }

        private int FindInOrderRootIndex(int[] inOrder, int root, int inOrderStart, int inOrderEnd)
        {
            for (int i = inOrderStart; i <= inOrderEnd; i++)
            {
                if (inOrder[i] == root)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}