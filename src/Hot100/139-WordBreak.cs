using System.Collections.Generic;
using System.Text;

namespace Hot100
{
    // good dp
    public class WordBreakSolution
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            var dp = new bool[s.Length + 1];
            dp[0] = true;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j <= s.Length; j++)
                {
                    if (dp[i] && wordDict.Contains(s.Substring(i, j - i)))
                    {
                        dp[j] = true;
                    }
                }
            }
            return dp[s.Length];
        }

        private IList<string[]> Split(string s, string subString)
        {
            var ret = new List<string[]>();
            var j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                while (i + j < s.Length && j < subString.Length && s[i + j] == subString[j])
                {
                    j++;
                }
                if (j == subString.Length)
                {
                    var splited = new string[] { s.Substring(0, i), s.Substring(i + j) };
                    ret.Add(splited);
                }
                j = 0;

            }
            return ret;
        }


    }
}