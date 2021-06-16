using System;
using System.Collections.Generic;

namespace Hot100
{
    public class MaxProductSolution
    {
        public int MaxProduct(int[] nums)
        {
            var minProd = 1;
            var maxProd = 1;
            var ret = int.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    var newMaxProd = maxProd > 0 ? maxProd * nums[i] : nums[i];
                    var newMinProd = minProd < 0 ? minProd * nums[i] : nums[i];
                    maxProd = newMaxProd;
                    minProd = newMinProd;
                    ret = Math.Max(ret, maxProd);
                }
                else if (nums[i] < 0)
                {
                    var newMaxProd = minProd < 0 ? minProd * nums[i] : nums[i];
                    var newMinProd = maxProd > 0 ? maxProd * nums[i] : nums[i];
                    maxProd = newMaxProd;
                    minProd = newMinProd;
                    ret = Math.Max(ret, maxProd);
                }
                else
                {
                    ret = Math.Max(ret, 0);
                    minProd = 1;
                    maxProd = 1;
                }

                // alternative:
                // var newMaxProd = Math.Max(nums[i], Math.Max(minProd * nums[i], maxProd * nums[i]));
                // var newMinProd = Math.Min(nums[i], Math.Min(minProd * nums[i], maxProd * nums[i]));
                // maxProd = newMaxProd;
                // minProd = newMinProd;
                // ret = Math.Max(ret, maxProd);
            }

            return ret;
        }
    }
}