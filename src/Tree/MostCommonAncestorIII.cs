using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicCoding
{
    public class MostCommonAncestorIIISolution
    {

        public TreeNode FindMostComonAncestor(TreeNode root, TreeNode a, TreeNode b)
        {
            var pathA = GetPath(root, a);
            var pathB = GetPath(root, b);
            var commonAncestor = GetLastCommonNode(pathA, pathB);
            return commonAncestor;
        }

        public TreeNode GetLastCommonNode(IList<TreeNode> a, IList<TreeNode> b)
        {
            var minLength = Math.Min(a.Count, b.Count);
            var lastCommonIndex = 0;
            for (int i = 0; i < minLength; i++)
            {
                if (a[i] != b[i])
                {
                    lastCommonIndex = i - 1;
                    break;
                }

                if (i == minLength - 1)
                {
                    lastCommonIndex = i;
                }
            }

            if (lastCommonIndex < 0)
            {
                throw new Exception($"can not find common node");
            }

            return a[lastCommonIndex];
        }
        public IList<TreeNode> GetPath(TreeNode root, TreeNode node)
        {
            var path = new LinkedList<TreeNode>();
            GetPath(root, node, path);

            return path.ToList();
        }

        public bool GetPath(TreeNode root, TreeNode node, LinkedList<TreeNode> path)
        {
            if (root == null || node == null)
            {
                return false;
            }
            path.AddLast(root);

            if (root.Value == node.Value)
            {
                return true;
            }

            if (GetPath(root.Left, node, path))
            {
                return true;
            }
            if (GetPath(root.Right, node, path))
            {
                return true;
            }

            path.RemoveLast();
            return false;
        }
    }
}