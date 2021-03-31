namespace BasicCoding
{
    public class RemoveNodeSolution
    {
        public void RemoveNode<T>(LinkNode<T> head, LinkNode<T> toBeRemoved)
        {
            if (head == null || toBeRemoved == null)
            {
                return;
            }

            if (toBeRemoved.Next != null)
            {
                var next = toBeRemoved.Next;
                toBeRemoved.Value = next.Value;
                toBeRemoved.Next = next.Next;
                return;
            }

            // if it is tail
            while (head != null)
            {
                if (head.Next == toBeRemoved)
                {
                    head.Next = null;
                }
                head = head.Next;
            }
        }
    }
}