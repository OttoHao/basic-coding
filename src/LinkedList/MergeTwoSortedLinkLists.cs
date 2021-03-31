using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicCoding
{
    public class MergeTwoSortedLinkListsSolution
    {
        public LinkNode<T> Merge<T>(LinkNode<T> a, LinkNode<T> b) where T : IComparable
        {
            if (a == null)
            {
                return b;
            }

            if (b == null)
            {
                return a;
            }

            LinkNode<T> head = null;

            if (a.Value.CompareTo(b.Value) <= 0)
            {
                head = a;
                a = a.Next;
            }
            else
            {
                head = b;
                b = b.Next;
            }

            head.Next = Merge(a, b);

            return head;
        }

        public LinkNode<T> Merge<T>(IList<LinkNode<T>> inputs) where T : IComparable
        {
            if (inputs == null || inputs.Count == 0)
            {
                return null;
            }

            LinkNode<T> head = null;

            for (int i = 0; i < inputs.Count; i++)
            {
                head = Merge(head, inputs[i]);
            }

            return head;
        }
    }
}