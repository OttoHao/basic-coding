// https://zhuanlan.zhihu.com/p/93530380
// https://leetcode-cn.com/problems/permutations/solution/hui-su-suan-fa-python-dai-ma-java-dai-ma-by-liweiw/
using System.Collections.Generic;
using System.Linq;

namespace BasicCoding
{
    public static class Permutation
    {
        public static IList<List<T>> Permutate<T>(IList<T> inputs)
        {
            var ret = new List<List<T>>();
            var path = new List<T>();
            var used = new List<bool>();
            Permutate(inputs, path, ret, used);
            return ret;
        }

        public static void Permutate<T>(IList<T> inputs, List<T> path, IList<List<T>> result, IList<bool> used)
        {
            if (path.Count == inputs.Count)
            {
                result.Add(new List<T>(path));
                return;
            }

            for (int i = 0; i < inputs.Count; i++)
            {
                if (used[i])
                {
                    continue;
                }
                
                path.Add(inputs[i]);
                used[i] = true;

                Permutate(inputs, path, result, used);
                
                path.RemoveAt(path.Count - 1);
                used[i] = false;
            }
        }
    }
}