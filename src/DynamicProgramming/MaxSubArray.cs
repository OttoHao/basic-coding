// https://leetcode-cn.com/problems/maximum-subarray/

using System;

namespace BasicCoding
{
    public static class MaxSubArraySolution
    {
        public static int MaxSubArray(int[] nums)
        {
            var sum = nums[0];
            var maxSum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                sum = Math.Max(sum + nums[i], nums[i]);
                maxSum = Math.Max(sum, maxSum);
            }

            return maxSum;
        }
    }
}

