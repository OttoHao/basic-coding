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
            var length = inputs.Count;
            var ret = new List<List<T>>();
            var path = new Stack<T>();
            var used = new bool[length];
            Permutate(inputs, path, ret, used, length, 0);
            return ret;
        }

        public static void Permutate<T>(IList<T> inputs, Stack<T> path, IList<List<T>> result, IList<bool> used, int length, int depth)
        {
            if (depth == length)
            {
                result.Add(new List<T>(path));
                return;
            }
            var set = new HashSet<T>();
            for (int i = 0; i < length; i++)
            {
                if (used[i])
                {
                    continue;
                }

                if (set.Contains(inputs[i]))
                {
                    continue;
                }

                set.Add(inputs[i]);
                path.Push(inputs[i]);
                used[i] = true;

                Permutate(inputs, path, result, used, length, depth + 1);

                path.Pop();
                used[i] = false;
            }
        }
    }
}