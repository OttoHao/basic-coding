namespace Hot100
{
    public class SearchInRotateArraySolution
    {
        public int Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0) return -1;
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var mid = (left + right) / 2;
                if (target == nums[mid]) return mid;

                if (nums[mid] >= nums[left])
                {
                    if (target < nums[mid] && target >= nums[left]) right = mid - 1;
                    else left = mid + 1;
                }
                else
                {
                    if (target > nums[mid] && target <= nums[right]) left = mid + 1;
                    else right = mid - 1;
                }                
            }
            return -1;
        }
    }
}