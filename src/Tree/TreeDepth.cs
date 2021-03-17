using System;

namespace BasicCoding
{
    public static partial class TreeUtility
    {
        public static int TreeDepth(TreeNode root)
        {
            if (root == null){
                return 0;
            }

            var left = TreeDepth(root.Left);
            var right = TreeDepth(root.Right);

            return Math.Max(left, right) + 1;
        }
    }
}