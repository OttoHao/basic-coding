using System.Collections.Generic;

namespace Hot100
{
    public class TwoSumsSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(target - nums[i]))
                {
                    return new int[]{i, dic[target - nums[i]]};
                }

                dic.Add(nums[i], i);
            }

            return new int[2];
        }
    }
}