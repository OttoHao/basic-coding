namespace Hot100
{
    public class SearchRangeInSortedArraySolution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0) return new int[] { -1, -1 };

            var left = 0;
            var right = nums.Length - 1;

            while (left < right)
            {
                var mid = (left + right) / 2;
                if (target > nums[mid]) left = mid + 1;
                else right = mid;
            }

            var l = nums[left] == target ? left : -1;

            right = nums.Length - 1;

            while (left < right)
            {
                var mid = (left + right + 1) / 2; // good: important
                if (target < nums[mid]) right = mid - 1;
                else left = mid;
            }

            var r = nums[right] == target ? right : -1;

            return new int[] { l, r };
        }
    }
}