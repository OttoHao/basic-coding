using System.Collections.Generic;
using System.Text;

namespace BasicCoding
{
    public class Codec
    {

        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            if (root == null) return "[]";
            var queue = new Queue<TreeNode>();
            var sb = new StringBuilder();
            sb.Append('[' + Enqueue(queue, root).ToString());

            while (queue.TryDequeue(out var node))
            {
                if (node != null)
                {
                    sb.Append(',' + Enqueue(queue, node).ToString());
                }
                else
                {
                    sb.Append(",null");
                }
            }
            sb.Append(']');
            return sb.ToString();
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            if (data == "[]") return null;
            var vals = data.Substring(1, data.Length - 2).Split(',');
            var root = new TreeNode(int.Parse(vals[0]));
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var i = 1;
            while (queue.TryDequeue(out var node))
            {
                if (vals[i] != "null")
                {
                    node.left = new TreeNode(int.Parse(vals[i]));
                    queue.Enqueue(node.left);
                }
                i++;

                if (vals[i] != "null")
                {
                    node.right = new TreeNode(int.Parse(vals[i]));
                    queue.Enqueue(node.right);
                }
                i++;
            }

            return root;

        }

        public int Enqueue(Queue<TreeNode> queue, TreeNode node)
        {
            queue.Enqueue(node.left);
            queue.Enqueue(node.right);

            return node.val;
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