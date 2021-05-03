namespace Hot100
{
    // good
    public class RemoveNthFromEndSolution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var slow = head;
            var fast = head;
            ListNode pre = null;

            for (int i = 0; i < n; i++)
            {
                fast = fast.next;
            }

            while (fast != null)
            {
                pre = slow;
                fast = fast.next;
                slow = slow.next;
            }

            if (pre == null) return head.next;
            pre.next = slow.next;

            return head;

        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}