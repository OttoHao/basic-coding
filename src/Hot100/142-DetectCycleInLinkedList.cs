namespace Hot100
{
    // fast = 2 * slow, fast = slow + n * b
    // good
    public class DetectCycleInLinkedListSolution
    {
        public ListNode DetectCycle(ListNode head)
        {
            var slow = head;
            var fast = head;
            while (fast?.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    fast = head;
                    while (slow != fast)
                    {
                        slow = slow.next;
                        fast = fast.next;
                    }
                    return slow;
                }
            }

            return null;
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