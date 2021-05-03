using System.Collections.Generic;

namespace Hot100
{
    public class IsValidBracketSolution
    {
        public bool IsValid(string s)
        {
            var stack = new Stack<char>();
            foreach (var item in s)
            {
                if (stack.TryPeek(out var top) && IsPair(top, item))
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(item);
                }
            }

            return !stack.TryPeek(out var any);
        }

        private bool IsPair(char a, char b)
        {
            if (a == '(' && b == ')') return true;
            if (a == '[' && b == ']') return true;
            if (a =='{' && b == '}') return true;
            return false;
        }
    }
}