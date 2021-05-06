namespace Hot100
{
    public class NumIslandsSolution
    {
        public int NumIslands(char[][] grid)
        {
            var rows = grid.Length;
            var cols = grid[0].Length;
            var count = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (grid[row][col] == '1')
                    {
                        count++;
                        Update(grid, row, col, rows, cols);
                    }
                }
            }
            return count;
        }

        private void Update(char[][] grid, int row, int col, int rows, int cols)
        {
            if (row < 0 || row >= rows || col < 0 || col >= cols) return;
            if (grid[row][col] == '0') return;
            grid[row][col] = '0';
            Update(grid, row - 1, col, rows, cols);
            Update(grid, row, col + 1, rows, cols);
            Update(grid, row + 1, col, rows, cols);
            Update(grid, row, col - 1, rows, cols);
        }
    }
}