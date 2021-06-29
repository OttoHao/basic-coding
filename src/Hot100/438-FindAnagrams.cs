using System;
using System.Collections.Generic;
using System.Linq;

namespace Hot100
{
    public class FindAnagramsSolution
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            var freqP = new int[26];
            foreach (var item in p)
            {
                freqP[item - 'a']++;
            }

            var ret = new List<int>();
            var freq = new int[26];
            var start = 0;
            var end = 0;

            while (end < s.Length)
            {
                freq[s[end] - 'a']++;
                end++;
                if (end - start == p.Length)
                {
                    if (Enumerable.SequenceEqual(freqP, freq)) ret.Add(start);
                    freq[s[start] - 'a']--;
                    start++;
                }
            }
            return ret;
        }

        private HashSet<string> Permute(string str)
        {
            var path = new LinkedList<char>();
            var set = new HashSet<string>();
            var used = new bool[str.Length];
            Permute(str, 0, path, set, used);
            return set;
        }

        private void Permute(string str, int depth, LinkedList<char> path, HashSet<string> set, bool[] used)
        {
            if (depth == str.Length)
            {
                set.Add(new string(path.ToArray()));
                return;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (used[i]) continue;
                path.AddLast(str[i]);
                used[i] = true;
                Permute(str, depth + 1, path, set, used);
                path.RemoveLast();
                used[i] = false;
            }
        }
    }
}