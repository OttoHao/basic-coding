using System.Collections.Generic;
using System.Linq;

namespace BasicCoding
{
    public static class StringPermutation
    {
        public static void PermutateString(char[] chars)
        {
            PermutateString(chars, 0);
        }

        private static void PermutateString(char[] chars, int index)
        {
            if (index == chars.Length - 1)
            {
                System.Console.WriteLine($"{new string(chars)}");
                return;
            }
            var set = new HashSet<char>();
            for (int i = index; i < chars.Length; i++)
            {
                if (set.Contains(chars[i]))
                {
                    continue;
                }
                set.Add(chars[i]);
                Swap(chars, i, index);
                System.Console.WriteLine($"before: {chars.Aggregate(string.Empty, (a,b)=> a+b)}");
                PermutateString(chars, index + 1);
                Swap(chars, index, i);
                System.Console.WriteLine($"after: {chars.Aggregate(string.Empty, (a,b)=> a+b)}");
            }
        }

        private static void Swap(char[] chars, int a, int b)
        {
            var temp = chars[a];
            chars[a] = chars[b];
            chars[b] = temp;
        }
    }
}