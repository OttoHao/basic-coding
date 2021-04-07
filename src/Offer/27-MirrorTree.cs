using System;

namespace BasicCoding
{
    public class MirrorTreeSolution
    {
        public TreeNode MirrorTree(TreeNode root)
        {   
            if (root == null) return null;
            
            SwapLeftAndRight(root);
            MirrorTree(root.left);
            MirrorTree(root.right);

            return root;
        }

        private void SwapLeftAndRight(TreeNode root)
        {
            var temp = root.right;
            root.right = root.left;
            root.left = temp;
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