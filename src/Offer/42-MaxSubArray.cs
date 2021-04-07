namespace BasicCoding
{
    public class MaxSubarraySolution
    {
        public int MaxSubArray(int[] nums)
        {
            var max = nums[0];
            var sum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                sum = sum <= 0 ? nums[i] : sum + nums[i];
                max = sum > max ? sum : max;
            }

            return max;
        }
    }
}