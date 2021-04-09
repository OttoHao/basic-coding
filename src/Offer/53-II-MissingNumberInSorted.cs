namespace BasicCoding
{
    public class MissingNumberInSortedSolution
    {
        public int MissingNumber(int[] nums)
        {
            return MissingNumber(nums, 0, nums.Length - 1);
        }

        private int MissingNumber(int[] nums, int start, int end)
        {
            while (start <= end)
            {
                var mid = start + (end - start) / 2;
                if (nums[mid] == mid) start = mid + 1;
                else end = mid - 1;
            }

            return start;
        }
    }
}