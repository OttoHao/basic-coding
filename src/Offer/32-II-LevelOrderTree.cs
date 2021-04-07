using System.Collections.Generic;
using System.Linq;

namespace BasicCoding
{
    public class MultiLineLevelOrderTreeSolution
    {
        private Queue<TreeNode> _firstQueue = new Queue<TreeNode>();
        private Queue<TreeNode> _secondQueue = new Queue<TreeNode>();
        private IList<IList<int>> _ret = new List<IList<int>>();
        private IList<int> _temp = new List<int>();
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            EnQueue(_firstQueue, root);
            AddToResult();
            while (_firstQueue.TryPeek(out var anyFirst) || _secondQueue.TryPeek(out var anySecond))
            {
                DeQueue(_firstQueue, _secondQueue);
                DeQueue(_secondQueue, _firstQueue);
            }

            return _ret;

        }
        private void AddToResult()
        {
            if (_temp.Count > 0)
            {
                _ret.Add(_temp);
            }
        }
        private void DeQueue(Queue<TreeNode> toBeDeQueued, Queue<TreeNode> toBeEnQueued)
        {
            _temp = new List<int>();
            while (toBeDeQueued.TryDequeue(out var item))
            {
                EnQueue(toBeEnQueued, item);
            }
            AddToResult();
        }

        private void EnQueue(Queue<TreeNode> queue, TreeNode root)
        {
            if (root == null) return;

            _temp.Add(root.val);
            queue.Enqueue(root.left);
            queue.Enqueue(root.right);
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