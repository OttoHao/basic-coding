using System;
using System.Collections.Generic;

namespace BasicCoding
{
    public class StackWithMin<T> where T : IComparable
    {
        private Stack<T> _mainStack = new Stack<T>();
        private Stack<T> _assistStack = new Stack<T>();

        public T Pop()
        {
            if (_mainStack.TryPeek(out var mainValue) && _assistStack.TryPeek(out var minValue))
            {
                if (mainValue.CompareTo(minValue) == 0)
                {
                    _assistStack.Pop();
                }
            }
            return _mainStack.Pop();
        }

        public void Push(T value)
        {
            if (_assistStack.TryPeek(out var min) && value.CompareTo(min) < 0)
            {
                _assistStack.Push(value);
            }

            if (!_assistStack.TryPeek(out var x))
            {
                _assistStack.Push(value);
            }

            _mainStack.Push(value);
        }

        public T Min()
        {
            if (_assistStack.TryPeek(out var min))
            {
                return min;
            }
            else
            {
                throw new Exception("no item in stack");
            }
        }
    }
}