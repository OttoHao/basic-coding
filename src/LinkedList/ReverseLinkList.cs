namespace BasicCoding
{
    public class ReverseLinkListSolution
    {
        public LinkNode<T> Reverse<T>(LinkNode<T> head)
        {
            LinkNode<T> prev = null;
            while (head != null)
            {
                var temp = head.Next;
                head.Next = prev;

                prev = head;
                head = temp;
            }

            return prev;
        }

        public LinkNode<T> ReverseRecursively<T>(LinkNode<T> head)
        {
            if (head == null)
            {
                return null;
            }

            if (head.Next == null)
            {
                return head;
            }

            var next = ReverseRecursively(head.Next);

            head.Next.Next = head;
            head.Next = null;

            return next;
        }
    }
}