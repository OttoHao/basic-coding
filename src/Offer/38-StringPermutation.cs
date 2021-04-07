using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicCoding
{
    // todo good to understand
    public class StringPermutationSolution
    {
        private IList<string> _ret = new List<string>();
        public string[] Permutation(string s)
        {
            var path = new LinkedList<char>();
            var used = new bool[s.Length];
            Permutation(s, path, 0, used);

            return _ret.Distinct().ToArray();
        }

        private void Permutation(string s, LinkedList<char> path, int index, bool[] used)
        {
            if (index == s.Length)
            {
                _ret.Add(new string(path.ToArray()));
                return;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (used[i]) continue;

                used[i] = true;
                path.AddLast(s[i]);
                Permutation(s, path, index + 1, used);
                path.RemoveLast();
                used[i] = false;
            }
        }
    }
}