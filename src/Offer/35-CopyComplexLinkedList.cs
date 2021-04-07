namespace BasicCoding
{
    public class CopyComplexLinkedListSolution
    {
        public Node CopyRandomList(Node head)
        {
            if (head == null) return null;

            var node = head;
            Node inserted = null;
            while (node != null)
            {
                inserted = new Node(node.val);
                inserted.next = node.next;

                node.next = inserted;
                node = inserted.next;
            }

            node = head;
            while (node != null)
            {
                if (node.random != null)
                {
                    node.next.random = node.random.next;
                }
                node = node.next.next;
            }

            // recover original input
            node = head.next;
            var ret = head.next;
            var pre = head;
            while (node.next != null)
            {   
                pre.next = pre.next.next;
                node.next = node.next.next;

                pre = pre.next;
                node = node.next;
            }

            pre.next = null;
            return ret;
        }
        public class Node
        {
            public int val;
            public Node next;
            public Node random;

            public Node(int _val)
            {
                val = _val;
                next = null;
                random = null;
            }
        }
    }
}