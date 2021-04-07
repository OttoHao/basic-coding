namespace BasicCoding
{
    public class MatrixPathSolution
    {
        private bool[][] _visited;
        public bool Exist(char[][] board, string word)
        {
            if (board == null || board.Length == 0 || board[0].Length == 0)
            {
                return false;
            }

            var rows = board.Length;
            var columns = board[0].Length;

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    InitVisited(rows, columns);
                    if (EqualsRecur(board, row, column, word, 0, rows, columns))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool EqualsRecur(char[][] board, int row, int column, string word, int wordIndex, int rows, int columns)
        {
            if (row >= rows || row < 0 || column >= columns || column < 0)
            {
                return false;
            }

            if (!(board[row][column] == word[wordIndex]) || _visited[row][column])
            {
                return false;
            }

            if (wordIndex == word.Length - 1)
            {
                return true;
            }

            _visited[row][column] = true;

            if (EqualsRecur(board, row - 1, column, word, wordIndex + 1, rows, columns) ||
                EqualsRecur(board, row, column - 1, word, wordIndex + 1, rows, columns) ||
                EqualsRecur(board, row + 1, column, word, wordIndex + 1, rows, columns) ||
                EqualsRecur(board, row, column + 1, word, wordIndex + 1, rows, columns))
            {
                return true;
            }

            _visited[row][column] = false;

            return false;
        }

        private void InitVisited(int rows, int columns)
        {
            _visited = new bool[rows][];

            for (int i = 0; i < rows; i++)
            {
                _visited[i] = new bool[columns];
            }
        }
    }
}