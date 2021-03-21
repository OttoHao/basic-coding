using System.Collections.Generic;

namespace BasicCoding
{
    public static class Combination
    {
        public static IList<List<T>> Combine<T>(IList<T> inputs)
        {
            var length = inputs.Count;
            var ret = new List<List<T>>();
            var path = new Stack<T>();
            for (int i = 1; i <= length; i++)
            {
                Combine(inputs, i, ret, path, 0);
            }

            return ret;
        }

        private static void Combine<T>(IList<T> inputs, int m, IList<List<T>> result, Stack<T> path, int depth)
        {
            if (m == 0)
            {
                result.Add(new List<T>(path));
                return;
            }

            if (inputs.Count <= depth)
            {
                return;
            }

            path.Push(inputs[depth]);
            Combine(inputs, m - 1, result, path, depth + 1);

            path.Pop();
            Combine(inputs, m, result, path, depth + 1);

        }
    }
}