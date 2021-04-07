using System.Collections.Generic;

namespace BasicCoding
{
    public class ValidateStackSequencesSolution
    {
        public bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            var stack = new Stack<int>();
            var i = 0;

            foreach (var item in pushed)
            {
                stack.Push(item);
                while (stack.TryPeek(out var top) && top == popped[i])
                {
                    stack.Pop();
                    i++;
                }
            }

            return !stack.TryPeek(out var any);
        }
    }
}