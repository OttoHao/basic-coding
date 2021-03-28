using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoding
{
    public class BinaryTreePathSumSolution
    {
        public IList<List<int>> PathSum(TreeNode root, int sum)
        {
            var ret = new List<List<int>>();
            var path = new LinkedList<int>();
            PathSum(root, path, ret, sum);
            return ret;
        }

        private void PathSum(TreeNode root, LinkedList<int> path, IList<List<int>> ret, int sum)
        {
            if (root == null)
            {
                return;
            }

            path.AddLast(root.Value);
            sum -= root.Value;

            if (sum == 0 && root.Left == null && root.Right == null)
            {
                ret.Add(new List<int>(path));
            }

            PathSum(root.Left, path, ret, sum);
            PathSum(root.Right, path, ret, sum);

            path.RemoveLast();
        }
    }
}