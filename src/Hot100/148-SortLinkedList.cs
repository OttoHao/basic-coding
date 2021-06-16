namespace Hot100
{
    public class SortLinkedListSolution
    {
        public ListNode SortList(ListNode head)
        {
            if (head == null || head.next == null) return head;
            var subLength = 1;
            var dummyHead = new ListNode(0, head);
            var length = GetLength(head);
            while (subLength < length)
            {
                var cur = dummyHead.next;
                var preTail = dummyHead;
                while (cur != null)
                {
                    var next = KthNodeFrom(cur, subLength);
                    var temp = KthNodeFrom(next, subLength);
                    preTail = Merge(cur, next, subLength, preTail, temp);
                    preTail.next = temp;
                    cur = temp;
                }
                subLength *= 2;
            }
            return dummyHead.next;
        }

        private int GetLength(ListNode head)
        {
            var length = 0;
            while (head != null)
            {
                head = head.next;
                length++;
            }
            return length;
        }

        private ListNode KthNodeFrom(ListNode cur, int k)
        {
            for (int i = 0; i < k; i++)
            {
                if (cur == null) return null;
                cur = cur.next;
            }
            return cur;
        }

        private ListNode Merge(ListNode cur, ListNode next, int k, ListNode pre, ListNode nextEnd)
        {
            var nextStart = next;

            while (cur != nextStart && next != nextEnd)
            {
                if (next == null)
                {
                    cur = cur.next;
                    pre = pre.next;
                    continue;
                }
                if (cur.val <= next.val)
                {
                    cur = cur.next;
                    pre = pre.next;
                }
                else
                {
                    var temp = next.next;
                    pre.next = next;
                    next.next = cur;

                    next = temp;
                    pre = pre.next;
                }
            }

            while (cur != nextStart)
            {
                cur = cur.next;
                pre = pre.next;
            }

            while (next != nextEnd)
            {
                next = next.next;
                pre = pre.next;
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