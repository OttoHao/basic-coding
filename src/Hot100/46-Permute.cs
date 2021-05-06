using System;
using System.Collections.Generic;
using System.Linq;

namespace Hot100
{
    public class PermuteSolution
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var ret = new List<IList<int>>();
            var path = new LinkedList<int>();
            var used = new bool[nums.Length];
            Permute(nums, 0, path, ret, used);
            return ret;
        }

        private void Permute(int[] nums, int depth, LinkedList<int> path, List<IList<int>> ret, bool[] used)
        {
            if (depth == nums.Length)
            {
                ret.Add(path.ToList());
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (used[i]) continue;
                path.AddLast(nums[i]);
                used[i] = true;
                Permute(nums, depth + 1, path, ret, used);
                path.RemoveLast();
                used[i] = false;
            }
        }
    }
}