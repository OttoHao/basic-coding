namespace BasicCoding
{
    public class TreeToDoublyListSolution
    {
        private Node _pre = null;
        private Node _head = null;
        public Node TreeToDoublyList(Node root)
        {
            Inorder(root);

            if (_head != null && _pre != null)
            {
                _head.left = _pre;
                _pre.right = _head;
            }

            return _head;
        }

        private void Inorder(Node root)
        {
            if (root == null) return;
            Inorder(root.left);

            if (_pre == null)
            {
                _head = root;
            }
            else
            {
                _pre.right = root;

            }

            root.left = _pre;
            _pre = root;

            Inorder(root.right);
        }

        public class Node
        {
            public int val;
            public Node left;
            public Node right;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
                left = null;
                right = null;
            }

            public Node(int _val, Node _left, Node _right)
            {
                val = _val;
                left = _left;
                right = _right;
            }
        }
    }
}