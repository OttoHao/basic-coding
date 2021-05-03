using System;
using System.Collections.Generic;

namespace Hot100
{
    public class ThreeSumsSolution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var ret = new List<IList<int>>();
            if (nums == null) return ret;

            Array.Sort(nums);

            var i = 0;
            while (i + 2 < nums.Length)
            {
                if (nums[i] > 0) return ret;

                var j = i + 1;
                var k = nums.Length - 1;

                while (j < k)
                {
                    var sum = nums[i] + nums[j] + nums[k];
                    if (sum > 0) k--;
                    else if (sum < 0) j++;
                    else
                    {
                        ret.Add(new List<int> { nums[i], nums[j], nums[k] });
                        j++;
                        while (j < nums.Length && nums[j] == nums[j-1]) j++;
                        k--;
                        while (k > 0 && nums[k] == nums[k+1]) k--;
                    }
                }
                i++;
                while (i < nums.Length && nums[i] == nums[i-1]) i++;
            }

            return ret;
        }
    }
}