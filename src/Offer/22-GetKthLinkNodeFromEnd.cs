namespace BasicCoding
{
    public class GetKthLinkNodeFromEndSolution
    {
        public ListNode GetKthFromEnd(ListNode head, int k)
        {
            if (k <= 0) throw new System.Exception("invalid k");
            var slow = head;
            var fast = head;
            for (int i = 0; i < k; i++)
            {
                if (fast == null) throw new System.Exception("k is too long");
                fast = fast.next;
            }

            while (fast != null)
            {
                fast = fast.next;
                slow = slow.next;
            }

            return slow;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}