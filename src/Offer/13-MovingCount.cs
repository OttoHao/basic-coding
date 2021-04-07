using System;

namespace BasciCoding
{
    public class MovingCountSolution
    {
        private int _count = 0;
        private bool[,] _visited;
        public int MovingCount(int m, int n, int k)
        {
            InitVisited(m, n);
            MovingCount(m, n, k, 0, 0);
            return _count;
        }

        private void InitVisited(int m, int n)
        {
            _visited = new bool[m,n];
        }

        public void MovingCount(int m, int n, int k, int i, int j)
        {
            if (i < 0 || i >= m || j < 0 || j >= n)
            {
                return;
            }

            if (_visited[i,j] || DigitSum(i) + DigitSum(j) > k)
            {
                return;
            }

            _count++;
            _visited[i,j] = true;
            MovingCount(m, n, k, i + 1, j);
            MovingCount(m, n, k, i, j + 1);
        }

        private int DigitSum(int number)
        {
            var sum = 0;
            while (number != 0){
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }
}