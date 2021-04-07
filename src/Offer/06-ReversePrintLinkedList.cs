using System.Collections;
using System.Collections.Generic;

namespace BasicCoding
{
    public class ReversePrintLinkedListSolution
    {
        public int[] ReversePrint(ListNode head)
        {
            var stack = new Stack<int>();
            while (head != null)
            {
                stack.Push(head.val);
                head = head.next;
            }

            var size = stack.Count;
            var ret = new int[size];
            for (int i = 0; i < size; i++)
            {
                ret[i] = stack.Pop();
            }

            return ret;
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}