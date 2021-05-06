namespace Hot100
{
    public class HasCycleInLinkedListSolution
    {
        public bool HasCycle(ListNode head)
        {
            var slow = head;
            var fast = head;
            while (fast?.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast) return true;
            }

            return false;
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }
    }
}