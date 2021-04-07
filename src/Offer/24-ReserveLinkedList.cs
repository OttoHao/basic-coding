namespace BasicCoding
{
    public class ReserveLinkedListSolution
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode pre = null;
            while (head != null)
            {
                var temp = head.next;
                head.next = pre;

                pre = head;
                head = temp;
            }

            return pre;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}