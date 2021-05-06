using System.Collections.Generic;

namespace Hot100
{
    public class LevelOrderOnTreeSolution
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var queue = new Queue<TreeNode>();
            var ret = new List<IList<int>>();
            var path = new List<int>();
            var temp = new List<TreeNode>();
            queue.Enqueue(root);

            while (queue.TryDequeue(out var item))
            {
                if (item != null)
                {

                    path.Add(item.val);
                    temp.Add(item.left);
                    temp.Add(item.right);
                }
                if (queue.Count == 0 && path.Count > 0)
                {
                    ret.Add(path);
                    foreach (var node in temp)
                    {
                        queue.Enqueue(node);
                    }
                    
                    path = new List<int>();
                    temp = new List<TreeNode>();
                }
            }
            return ret;
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