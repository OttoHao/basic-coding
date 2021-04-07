namespace BasicCoding
{
    public class DeleteLinkNodeSolution
    {
        public ListNode DeleteNode(ListNode head, int val)
        {
            if (head == null)
            {
                return null;
            }

            if (head.val == val)
            {
                return head.next;
            }

            ListNode pre = null;
            var node = head;
            while (node != null)
            {
                pre = node;
                node = node.next;

                if (node.val == val)
                {
                    pre.next = node.next;
                    break;
                }
            }
            return head;
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}