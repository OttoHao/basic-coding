namespace BasicCoding
{
    public class VerifyPostOrderSolution
    {
        public bool VerifyPostOrder(int[] postOrder)
        {
            return VerifyPostOrder(postOrder, 0, postOrder.Length - 1);
        }
        public bool VerifyPostOrder(int[] postOrder, int start, int end)
        {
            if (start >= end)
            {
                return true;
            }

            var index = start;

            while (postOrder[index] < postOrder[end])
            {
                index++;
            }

            var middle = index;

            while (postOrder[index] > postOrder[end])
            {
                index++;
            }

            return index == end && VerifyPostOrder(postOrder, start, middle - 1) && VerifyPostOrder(postOrder, middle, end - 1);
        }
    }
}