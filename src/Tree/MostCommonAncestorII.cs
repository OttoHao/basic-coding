using System.Collections.Generic;
using System.Linq;

namespace BasicCoding
{
    public class MostCommonAncestorIISolution
    {
        public GeneralTreeNode FindMostCommonAncestor(GeneralTreeNode root, GeneralTreeNode a, GeneralTreeNode b)
        {
            if (root == null)
            {
                return null;
            }

            if (root.Value == a.Value || root.Value == b.Value)
            {
                return root;
            }

            if (root.Children == null)
            {
                return null;
            }

            var ancestors = new List<GeneralTreeNode>();
            var ancestorCount = 0;

            foreach (var currentchild in root.Children)
            {
                var ancestor = FindMostCommonAncestor(currentchild, a, b);
                if (ancestor != null)
                {
                    ancestors.Add(ancestor);
                    ancestorCount++;
                }

                if (ancestorCount >= 2)
                {
                    return root;
                }
            }

            return ancestors.FirstOrDefault(a => a != null);

        }
    }

    public class GeneralTreeNode
    {
        public int Value { get; set; }
        public IEnumerable<GeneralTreeNode> Children { get; set; }

        public GeneralTreeNode(int value)
        {
            Value = value;
        }
    }
}