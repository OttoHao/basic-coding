using System;
using System.Collections.Generic;

namespace Hot100
{
    public class NumSquaresSolution
    {
        private int _count;
        private int _minCount;
        public int NumSquares(int n)
        {
            _count = 0;
            _minCount = n;
            var num = (int)Math.Sqrt(n);
            Dfs(n, num);
            return _minCount;
        }

        private void Dfs(int n, int num)
        {
            if (n < 0) return;
            if (n == 0)
            {
                _minCount = Math.Min(_minCount, _count);
                return;
            }
            for (int i = num; i >= 1; i--)
            {
                n -= i * i;
                _count++;
                if (_count < _minCount)
                    Dfs(n, i);
                n += i * i;
                _count--;
            }
        }
    }
}