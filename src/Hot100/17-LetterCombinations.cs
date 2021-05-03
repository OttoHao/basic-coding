using System;
using System.Collections.Generic;
using System.Linq;

namespace Hot100
{
    public class LetterCombinationsSolution
    {
        private Dictionary<char, string> _dic = new Dictionary<char, string>{
            {'2', "abc"},
            {'3', "def"},
            {'4', "ghi"},
            {'5', "jkl"},
            {'6', "mno"},
            {'7', "pqrs"},
            {'8', "tuv"},
            {'9', "wxyz"}
        };
        public IList<string> LetterCombinations(string digits)
        {
            var ret = new List<string>();
            if (digits == null || digits.Length == 0) return ret;
            var path = new LinkedList<char>();
            LetterCombinations(digits, path, 0, ret);
            return ret;
        }

        private void LetterCombinations(string digits, LinkedList<char> path, int index, List<string> ret)
        {
            if (index == digits.Length){
                ret.Add(new string(path.ToArray()));
                return;
            }

            foreach (var item in _dic[digits[index]])
            {
                path.AddLast(item);
                LetterCombinations(digits, path, index + 1, ret);
                path.RemoveLast();
            }
        }
    }
}