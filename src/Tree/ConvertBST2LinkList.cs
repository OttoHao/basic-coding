namespace BasicCoding
{
    public class ConvertBST2LinkListSolution
    {
        private LinkListNode _prev = null;
        private LinkListNode _head = null;
        public LinkListNode Convert(TreeNode root)
        {
            ConvertRecursively(root);
            return _head;
        }
        public void ConvertRecursively(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            ConvertRecursively(root.Left);

            var current = new LinkListNode(root.Value);
            if (_prev != null)
            {
                _prev.Next = current;
            }
            else
            {
                _head = current;
            }

            current.Prev = _prev;

            _prev = current;

            ConvertRecursively(root.Right);
        }
    }

    public class LinkListNode
    {
        public int Value { get; set; }
        public LinkListNode Prev { get; set; }
        public LinkListNode Next { get; set; }

        public LinkListNode(int value, LinkListNode prev = null, LinkListNode next = null)
        {
            Value = value;
            Prev = prev;
            Next = next;
        }
    }
}