using System;
using System.Collections.Generic;
using System.Linq;

namespace Hot100
{
    public class CanPartitionSolution
    {
        public bool CanPartition(int[] nums)
        {
            if (nums == null || nums.Length <= 1) return false;
            var sum = nums.Sum();
            if ((sum & 1) == 1) return false;
            var target = sum / 2;
            var dp = new bool[target + 1];


            dp[0] = true;
            if (nums[0] <= target)
                dp[nums[0]] = true;

            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = target; j >= 1; j--)
                {
                    if (j >= nums[i])
                        dp[j] = dp[j] || dp[j - nums[i]];
                }
            }

            return dp[target];
        }
    }
}