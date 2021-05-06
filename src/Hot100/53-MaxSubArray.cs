using System;

namespace Hot100
{
    public class MaxSubArraySolution
    {
        public int MaxSubArray(int[] nums)
        {
            var sum = int.MinValue;
            var maxSum = sum;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum < 0 ? nums[i] : sum + nums[i];
                maxSum = Math.Max(maxSum, sum);
            }

            return maxSum;
        }
    }
}