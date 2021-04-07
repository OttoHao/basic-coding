using System;

namespace BasicCoding
{
    public class GetIntersectionNodeSolution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var lengthA = GetLength(headA);
            var lengthB = GetLength(headB);

            if (lengthA < lengthB)
            {
                var temp = headA;
                headA = headB;
                headB = temp;
            }

            var diff = Math.Abs(lengthA - lengthB);

            for (int i = 0; i < diff; i++)
            {
                headA = headA.next;
            }

            while (headA != headB)
            {
                headA = headA.next;
                headB= headB.next;
            }

            return headA;
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
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}