using System;
using System.Collections.Generic;

namespace Hot100
{
    public class LengthOfLongestSubstringSolution
    {
        // f(i) = f(i-1) + 1 or d
        public int LengthOfLongestSubstring(string s)
        {
            if (s == null || s.Length == 0) return 0;
            var d = new Dictionary<char, int>();
            var dp = 0;
            var maxDp = dp;

            for (int i = 0; i < s.Length; i++)
            {
                if (d.ContainsKey(s[i]))
                {
                    var distance = i - d[s[i]];
                    dp = Math.Min(distance, ++dp);

                    d[s[i]] = i;
                }
                else
                {
                    dp++;
                    d.Add(s[i], i);
                }

                maxDp = Math.Max(maxDp, dp);
            }
            return maxDp;
        }
    }
}