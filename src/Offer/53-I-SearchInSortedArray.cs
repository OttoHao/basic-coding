namespace BasicCoding
{
    public class SearchInSortedArraySolution
    {
        public int Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0) return 0;
            var index = BinarySearch(nums, 0, nums.Length - 1, target);
            if (index == -1) return 0;

            var pre = index - 1;
            var next = index + 1;
            while (pre >=0 && nums[pre] == target) pre--;
            while (next < nums.Length && nums[next] == target) next++;


            return next - pre - 1;
        }

        public int BinarySearch(int[] nums, int start, int end, int target)
        {
            while (start < end)
            {
                var mid = start + (end - start) / 2;
                if (nums[mid] == target) return mid;
                else if (nums[mid] > target) end = mid - 1;
                else start = mid + 1;
            }

            if (nums[start] == target) return start;
            return -1;
        }
    }
}