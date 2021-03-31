using System.Collections.Generic;

namespace BasicCoding
{
    public class PrintFromTailToHeadSolution
    {
        public void Print<T>(LinkNode<T> head)
        {
            var stack = new Stack<T>();
            while (head != null)
            {
                stack.Push(head.Value);
                head = head.Next;
            }

            while (stack.TryPop(out T item))
            {
                System.Console.WriteLine(item.ToString());
            }
        }
    }
}