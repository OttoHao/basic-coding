using System.Collections.Generic;

namespace BasicCoding
{
    public class FirstUniqCharSolution
    {
        public char FirstUniqChar(string s)
        {
            var dic = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                var key = s[i];
                if (dic.ContainsKey(key))
                {
                    dic[key]++;
                }
                else
                {
                    dic.Add(key, 1);
                }
            }

            foreach (var item in dic)
            {
                if (item.Value == 1)
                {
                    return item.Key;
                }
            }

            return ' ';
        }
    }
}