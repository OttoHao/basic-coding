using System.Collections.Generic;
using System.Linq;

namespace BasicCoding
{
    // todo a good question
    public class LevelOrderTreeSolution
    {
        public int[] LevelOrder(TreeNode root)
        {
            var queue = new Queue<TreeNode>();
            var ret = new List<int>();
            
            queue.Enqueue(root);

            while (queue.TryDequeue(out var item))
            {
                if (item != null)
                {
                    ret.Add(item.val);
                    queue.Enqueue(item.left);
                    queue.Enqueue(item.right);
                }
            }

            return ret.ToArray();
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