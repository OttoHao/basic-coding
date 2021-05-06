using System;
using System.Collections.Generic;
using System.Linq;

namespace Hot100
{
    public class CombinationSumSolution
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            var ret = new List<IList<int>>();
            var path = new LinkedList<int>();
            CombinationSum(candidates, path, 0, target, ret);
            return ret;
        }

        private void CombinationSum(int[] candidates, LinkedList<int> path, int index, int target, List<IList<int>> ret)
        {
            if (target < 0) return;
            if (target == 0) {
                ret.Add(path.ToList());
                return;
            }
            for (int i = index; i < candidates.Length; i++)
            {
                path.AddLast(candidates[i]);
                target-=candidates[i];
                CombinationSum(candidates, path, i, target, ret);
                path.RemoveLast();
                target+=candidates[i];
            }
        }
    }
}