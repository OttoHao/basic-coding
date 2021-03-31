namespace BasicCoding
{
    public class FindKthToTailSolution
    {
        public LinkNode<T> FindKthToTail<T>(LinkNode<T> head, int k)
        {
            if (head == null || k <= 0)
            {
                return null;
            }

            var slow = head;
            var fast = head;

            for (int i = 0; i < k; i++)
            {
                if (fast == null)
                {
                    throw new System.Exception($"{k} is too big");
                }
                fast = fast.Next;
            }

            while (fast != null)
            {
                slow = slow.Next;
                fast = fast.Next;
            }

            return slow;
        }
    }
}