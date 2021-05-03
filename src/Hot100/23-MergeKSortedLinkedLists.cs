using System;
using System.Collections.Generic;
using System.Linq;

namespace Hot100
{
    public class MergeKListsSolution
    {

        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length == 0) return null;

            return MergeKLists(lists, 0, lists.Length - 1);
        }

        private ListNode MergeKLists(ListNode[] lists, int left, int right)
        {
            if (left >= right) return lists[left];
            var mid = (left + right) / 2;
            var a = MergeKLists(lists, left, mid);
            var b = MergeKLists(lists, mid + 1, right);
            return MergeLists(a, b);
        }

        private ListNode MergeLists(ListNode a, ListNode b)
        {
            if (a == null) return b;
            if (b == null) return a;

            var val = 0;
            if (a.val <= b.val)
            {
                val = a.val;
                a = a.next;
            }
            else
            {
                val = b.val;
                b = b.next;
            }

            var root = new ListNode(val);
            root.next = MergeLists(a, b);

            return root;

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