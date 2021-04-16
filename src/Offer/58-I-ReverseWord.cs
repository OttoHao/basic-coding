using System.Linq;
using System.Text;

namespace BasicCoding
{
    public class ReverseWordSolution
    {
        public string ReverseWords(string s)
        {
            var strs = s.Trim().Split(' ')
                .Where(str => !string.IsNullOrEmpty(str))
                .ToArray();

            var start = 0;
            var end = strs.Length - 1;

            while (start < end)
            {
                Swap(strs, start, end);
                start++;
                end--;
            }

            var sb = new StringBuilder();

            sb.AppendJoin(' ', strs);

            return sb.ToString();
        }

        private void Swap(string[] strs, int start, int end)
        {
            var temp = strs[start];
            strs[start] = strs[end];
            strs[end] = temp;
        }
    }
}