namespace BasicCoding
{
    public class AddTwoLinkedListSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null) return null;

            int preDigit = 0, v, sum;
            ListNode head = null;
            ListNode node = head;
            while (l1 != null || l2 != null)
            {
                var v1 = l1 == null ? 0 : l1.val;
                var v2 = l2 == null ? 0 : l2.val;

                sum = v1 + v2 + preDigit;
                v = sum % 10;
                preDigit = sum / 10;
                if (node == null)
                {
                    node = new ListNode(v);
                    head = node;
                }
                else
                {
                    node.next = new ListNode(v);
                    node = node.next;
                }

                l1 = l1 == null ? l1 : l1.next;
                l2 = l2 == null ? l2 : l2.next;
            }

            if (preDigit > 0)
            {
                node.next = new ListNode(preDigit);
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