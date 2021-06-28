using System.Collections.Generic;
using System.Linq;

namespace Hot100
{
    public class PathSumIIISolution
    {
        private int _count;
        public int PathSum(TreeNode root, int targetSum)
        {
            _count = 0;
            GetPossibleSums(root, targetSum);
            return _count;
        }

        public int[] GetPossibleSums(TreeNode root, int targetSum)
        {
            if (root == null) return new int[0];

            var left = GetPossibleSums(root.left, targetSum);
            var right = GetPossibleSums(root.right, targetSum);

            var set = new List<int>();

            foreach (var item in left)
            {
                set.Add(item + root.val);
                if (targetSum == item + root.val) _count++;
            }

            foreach (var item in right)
            {
                set.Add(item + root.val);
                if (targetSum == item + root.val) _count++;
            }

            set.Add(root.val);
            if (targetSum == root.val) _count++;

            return set.ToArray();
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