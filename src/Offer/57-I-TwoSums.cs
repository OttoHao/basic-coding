namespace BasicCoding
{
    public class TwoSumsSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var start = 0;
            var end = nums.Length - 1;

            while (start < end)
            {
                var sum = nums[start] + nums[end];
                if (target > sum)
                {
                    start++;
                }
                else if (target < sum)
                {
                    end--;
                }
                else
                {
                    return new int[] { nums[start], nums[end] };
                }
            }

            return new int[0];
        }
    }
}