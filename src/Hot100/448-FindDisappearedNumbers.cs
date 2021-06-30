using System;
using System.Collections.Generic;

namespace Hot100
{
    // [4,3,2,7,8,2,3,1]
    // [7,3,2,4,8,2,3,1]
    // [3,3,2,4,8,2,7,1]
    // [2,3,3,4,8,2,7,1]
    // [3,2,3,4,8,2,7,1]
    // [0,2,3,4,8,2,7,1]
    // [0,2,3,4,1,2,7,8]
    // [1,2,3,4,0,0,7,8]
    public class FindDisappearedNumbersSolution
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            var ret = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                while (nums[i] - 1 != i)
                {
                    if (nums[i] == nums[nums[i] - 1])
                    {
                        nums[i] = 0;
                        break;
                    }
                    Swap(nums, i, nums[i] - 1);
                    if (nums[i] == 0)
                    {
                        break;
                    }
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    ret.Add(i + 1);
                }
            }
            return ret;
        }

        private void Swap(int[] nums, int i, int j)
        {
            var temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}