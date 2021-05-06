using System.Collections.Generic;

namespace Hot100
{
    public class ZigzagLevelOrderSolution
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            var queue = new Queue<TreeNode>();
            var ret = new List<IList<int>>();
            var path = new List<int>();
            var temp = new List<TreeNode>();
            var leftToRight = true;
            queue.Enqueue(root);

            while (queue.TryDequeue(out var item))
            {
                if (item != null)
                {
                    path.Add(item.val);
                    if (leftToRight)
                    {
                        temp.Add(item.left);
                        temp.Add(item.right);
                    }
                    else
                    {
                        temp.Add(item.right);
                        temp.Add(item.left);
                    }

                }
                if (queue.Count == 0 && path.Count > 0)
                {
                    ret.Add(path);

                    for (int i = temp.Count - 1; i >= 0; i--)
                    {
                        queue.Enqueue(temp[i]);
                    }

                    leftToRight = !leftToRight;
                    temp = new List<TreeNode>();
                    path = new List<int>();
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