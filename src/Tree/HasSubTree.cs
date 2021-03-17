namespace BasicCoding
{
    public static partial class TreeUtility
    {
        public static bool HasSubTree(TreeNode root1, TreeNode root2)
        {
            if (root1 == null || root2 == null){
                return false;
            }

            var r1 = Recur(root1, root2);
            var r2 = HasSubTree(root1.Left, root2);
            var r3 = HasSubTree(root1.Right, root2);

            return r1 || r2 || r3;

        }

        private static bool Recur(TreeNode root1, TreeNode root2)
        {
            if (root1 == null){
                return false;
            }
            if (root2 == null){
                return true;
            }
            if (root1.Value != root2.Value){
                return false;
            }

            return Recur(root1.Left, root2.Left) && Recur(root1.Right, root2.Right);
        }
    }
}