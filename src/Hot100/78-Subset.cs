using System;
using System.Collections.Generic;
using System.Linq;

namespace Hot100
{
    public class SubsetSolution
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            var ret = new List<IList<int>>();
            var path = new LinkedList<int>();
            for (int i = 0; i <= nums.Length; i++)
            {
                Recur(nums, i, 0, path, ret);
            }

            return ret;
        }

        private void Recur(int[] nums, int m, int startIndex, LinkedList<int> path, List<IList<int>> ret)
        {
            if (m == 0)
            {
                ret.Add(path.ToArray());
                return;
            }

            if (startIndex >= nums.Length) return;

            path.AddLast(nums[startIndex]);
            Recur(nums, m-1, startIndex+1, path, ret);

            path.RemoveLast();
            Recur(nums, m, startIndex+1, path, ret);
        }
    }
}