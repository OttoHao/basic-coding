using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace BasicCoding
{
    public class MinNumberFromArraySolution
    {
        public string MinNumber(int[] nums)
        {
            var strs = nums.Select(num => num.ToString()).ToArray();;
            Array.Sort(strs, (x, y) => (x+y).CompareTo(y+x));

            var sb = new StringBuilder();
            foreach (var str in strs)
            {
                sb.Append(str);
            }

            return sb.ToString();
        }

    }
}