namespace Hot100
{
    public class AddTwoLinkedListsSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            // good: add dummy head, and return head.next
            ListNode head = new ListNode(0);
            ListNode node = head;
            int carry = 0;
            while (l1 != null || l2 != null || carry != 0)
            {
                var v1 = l1 == null ? 0 : l1.val;
                var v2 = l2 == null ? 0 : l2.val;
                var sum = v1 + v2 + carry;
                var v = sum % 10;

                node.next = new ListNode(v);
                node = node.next;

                carry = sum / 10;

                l1 = l1?.next;
                l2 = l2?.next;
            }

            return head.next;
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