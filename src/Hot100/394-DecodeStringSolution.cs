using System.Collections.Generic;
using System.Text;

namespace Hot100
{
    public class DecodeStringSolution
    {

        // a3[b]
        public string DecodeString(string s)
        {
            var countStack = new Stack<int>();
            var strStack = new Stack<string>();
            var ret = new StringBuilder();
            var count = 0;

            foreach (var item in s)
            {
                if (item == '[')
                {
                    countStack.Push(count);
                    strStack.Push(ret.ToString());
                    count = 0;
                    ret.Clear();
                }
                else if (item == ']')
                {
                    var temp = new StringBuilder();
                    var currentCount = countStack.Pop();
                    for (int i = 0; i < currentCount; i++)
                    {
                        temp.Append(ret.ToString());
                    }
                    ret.Clear();
                    ret.Append(strStack.Pop());
                    ret.Append(temp);
                }
                else if (item >= '0' && item <= '9')
                {
                    count = 10 * count + (item - '0');
                }
                else
                {
                    ret.Append(item);
                }
            }
            return ret.ToString();

        }
    }
}