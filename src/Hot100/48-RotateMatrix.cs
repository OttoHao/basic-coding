namespace Hot100
{
    public class RotateMatrixSolution
    {
        public void Rotate(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0) return;

            var index = 0;
            var n = matrix.Length - 1;

            while (index <= n /2)
            {
                for (int i = index; i < n - index; i++)
                {
                    Rotate(matrix, i, index, n);
                }
                index++;
            }
        }

        private void Rotate(int[][] matrix, int row, int col, int n)
        {
            var temp = matrix[row][col];
            matrix[row][col] = matrix[n - col][row];
            matrix[n - col][row] = matrix[n - row][n - col];
            matrix[n - row][n - col] = matrix[col][n - row];
            matrix[col][n - row] = temp;
        }
    }
}