namespace BasicCoding
{
    public class MostCommonAncestorSolution
    {
        public TreeNode FindMostComonAncestor(TreeNode root, TreeNode a, TreeNode b)
        {
            if (root == null)
            {
                return null;
            }

            if (root == a || root == b)
            {
                return root;
            }
            
            var left = FindMostComonAncestor(root.Left, a, b);
            var right = FindMostComonAncestor(root.Right, a, b);
            if (left != null && right != null)
            {
                return root;
            }
            return left == null ? right : left;
        }
    }
}