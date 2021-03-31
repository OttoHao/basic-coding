using System;

namespace BasicCoding
{
    public class FindFirstCommonNodeSolution
    {
        public LinkNode<T> FindFirstCommonNode<T>(LinkNode<T> a, LinkNode<T> b)
        {
            var longer = a;
            var shorter = b;

            var aLength = GetLength(a);
            var bLength = GetLength(b);

            if (aLength < bLength)
            {
                longer = b;
                shorter = a;
            }

            var diff = Math.Abs(aLength - bLength);

            for (int i = 0; i < diff; i++)
            {
                longer = longer.Next;
            }

            while (longer != null && shorter != null && longer != shorter)
            {
                shorter = shorter.Next;
                longer = longer.Next;
            }

            return shorter;
        }

        public LinkNode<T> FindFirstCommonNode2<T>(LinkNode<T> a, LinkNode<T> b)
        {
            while (a != b)
            {
                a = a == null ? b : a.Next;
                b = b == null? a: b.Next;
            }

            return a;
        }

        private int GetLength<T>(LinkNode<T> head)
        {
            var length = 0;

            while (head != null)
            {
                head = head.Next;
                length++;
            }
            return length;
        }
    }
}