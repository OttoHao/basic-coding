namespace BasicCoding
{
    public static class NextNodeInOrder
    {
        public static TreeNodeWithParent FindNextNodeInOrder(TreeNodeWithParent node)
        {
            if (node == null)
            {
                return null;
            }


            if (node.Right != null)
            {
                var right = node.Right;
                while (right.Left != null)
                {
                    right = right.Left;
                }
                return right;
            }

            if (node.Parent != null)
            {
                var current = node;
                var parent = node.Parent;

                while (parent!= null && ReferenceEquals(current, parent.Right))
                {
                    current = parent;
                    parent = parent.Parent;
                }

                return parent;
            }

            return null;

        }
    }

    public class TreeNodeWithParent
    {
        public int Value { get; set; }
        public TreeNodeWithParent Left { get; set; }
        public TreeNodeWithParent Right { get; set; }
        public TreeNodeWithParent Parent { get; set; }
    }
}