namespace BasicCoding
{
    public class VerifyPostorderSolution
    {
        public bool VerifyPostorder(int[] postorder)
        {
            var start = 0;
            var end = postorder.Length - 1;

            return VerifyPostorder(postorder, start, end);
        }

        private bool VerifyPostorder(int[] postorder, int start, int end)
        {
            if (start > end)
            {
                return false;
            }

            if (start == end)
            {
                return true;
            }

            var root = postorder[end];

            var i = start;

            while (postorder[i] < root)
            {
                i++;
            }

            var middle = i;

            while (postorder[i] > root)
            {
                i++;
            }

            if (i != end) return false;

            return VerifyPostorder(postorder, start, middle - 1) &&
                    VerifyPostorder(postorder, middle, end - 1);
        }
    }
}