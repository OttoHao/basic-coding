namespace Hot100
{
    public class SearchMatrixSolution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            var rows = matrix.Length;
            var cols = matrix[0].Length;
            var row = 0;
            var col = cols - 1;
            while (row < rows && col >= 0)
            {
                var num = matrix[row][col];
                if (target > num)
                {
                    row++;
                }
                else if (target < num)
                {
                    col--;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}