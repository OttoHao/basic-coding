
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoding
{
    public class BinaryTreePathsSolution
    {
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            var ret = new List<string>();
            BinaryTreePaths(root, string.Empty, ret);
            return ret;
        }

        private void BinaryTreePaths(TreeNode root, string path, List<string> ret)
        {
            if (root == null)
            {
                return;
            }

            var sb = new StringBuilder(path);
            sb.Append(root.Value);
            System.Console.WriteLine($"append {root.Value}");

            if (root.Left == null && root.Right == null)
            {
                ret.Add(sb.ToString());
                System.Console.WriteLine($"result: {sb.ToString()}");
            }

            BinaryTreePaths(root.Left, sb.ToString(), ret);
            BinaryTreePaths(root.Right, sb.ToString(), ret);

            System.Console.WriteLine($"try to remove {sb.ToString()[sb.Length - 1]}");         
        }
    }
}