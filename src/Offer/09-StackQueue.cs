using System.Collections.Generic;

namespace BasicCoding
{
    public class CQueue
    {
        private Stack<int> _firstStack = new Stack<int>();
        private Stack<int> _secondStack = new Stack<int>();
        public CQueue()
        {

        }

        public void AppendTail(int value)
        {
            _firstStack.Push(value);
        }

        public int DeleteHead()
        {
            if (_secondStack.TryPop(out var ret))
            {
                return ret;
            }

            while (_firstStack.TryPop(out var item))
            {
                _secondStack.Push(item);
            }

            if (_secondStack.TryPop(out var res))
            {
                return res;
            }

            return -1;
        }
    }
}