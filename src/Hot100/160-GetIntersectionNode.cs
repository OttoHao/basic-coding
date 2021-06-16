using System;

namespace Hot100
{
    public class GetIntersectionNodeSolution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null) return null;

            var a = headA;
            var b = headB;

            var lengthA = GetLength(a);
            var lengthB = GetLength(b);

            if (lengthA < lengthB)
            {
                a = headB;
                b = headA;
            }

            var diff = Math.Abs(lengthA - lengthB);

            for (int i = 0; i < diff; i++)
            {
                a = a.next;
            }

            while (a != null && b != null && a != b)
            {
                a = a.next;
                b = b.next;
            }
            return a;
        }

        private int GetLength(ListNode head)
        {
            var l = 0;
            while (head != null)
            {
                head = head.next;
                l++;
            }
            return l;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}