using System.Collections.Generic;
using System.Linq;

namespace BasicCoding
{
    // todo a good question
    public class LevelOrderTreeSolution
    {
        private Queue<TreeNode> _queue = new Queue<TreeNode>();
        private IList<int> _ret = new List<int>();
        public int[] LevelOrder(TreeNode root)
        {
            LevelOrderTree(root);

            while (_queue.TryDequeue(out var item))
            {
                LevelOrderTree(item);
            }

            return _ret.ToArray();
        }

        public void LevelOrderTree(TreeNode root)
        {
            if (root == null) return;

            _ret.Add(root.val);
            _queue.Enqueue(root.left);
            _queue.Enqueue(root.right);
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