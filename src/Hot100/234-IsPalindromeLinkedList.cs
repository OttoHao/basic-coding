namespace Hot100
{
    public class IsPalindromeLinkedListSolution
    {
        public bool IsPalindrome2(ListNode head)
        {
            var slow = head;
            var fast = head;
            ListNode pre = null;
            while (fast?.next != null)
            {
                fast = fast.next.next;

                var temp = slow.next;
                slow.next = pre;
                pre = slow;
                slow = temp;
            }

            if (fast != null) slow = slow.next; //good to check odd/even
            while (slow != null)
            {
                if (pre.val != slow.val) return false;
                pre = pre.next;
                slow = slow.next;
            }
            return true;
        }

        public bool IsPalindrome1(ListNode head)
        {
            ListNode tail = Reverse(head);

            while (tail != null && head != null && tail != head)
            {
                if (tail.val != head.val) return false;
                tail = tail.next;
                head = head.next;
            }
            return true;
        }

        private static ListNode Reverse(ListNode head)
        {
            ListNode pre = null;
            while (head != null)
            {
                var temp = head.next;
                head = new ListNode(head.val, pre);
                pre = head;
                head = temp;
            }

            return pre;
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