using System;
using System.Collections.Generic;

namespace BasicCoding
{
    public class LengthOfLongestSubstringSolution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var d = GetDistanceFromPre(s);
            var dp = 0;
            var maxDp = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (d[i] < 0 || d[i] > dp)
                {
                    dp++;
                }
                else
                {
                    dp = d[i];
                }
                maxDp = Math.Max(dp, maxDp);
            }

            return maxDp;
        }

        private int[] GetDistanceFromPre(string s)
        {
            var dic = new Dictionary<char, int>();
            var d = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                var cur = s[i];
                if (dic.ContainsKey(cur))
                {
                    var preIndex = dic[cur];
                    d[i] = i - preIndex;
                    dic[cur] = i;
                }
                else
                {
                    d[i] = -1;
                    dic.Add(cur, i);
                }
            }

            return d;
        }
    }
}