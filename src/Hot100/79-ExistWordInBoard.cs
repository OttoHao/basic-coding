namespace Hot100
{
    public class ExistWordInBoardSolution
    {
        public bool Exist(char[][] board, string word)
        {
            if (board == null || board.Length == 0 || board[0].Length == 0) return false;
            if (word == null || word.Length == 0) return false;

            var rows = board.Length;
            var cols = board[0].Length;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    var visited = new bool[rows, cols];
                    if (ExistFromCurrentNode(board, i, j, word, 0, rows, cols, visited)) return true;
                }
            }

            return false;

        }

        private bool ExistFromCurrentNode(char[][] board, int i, int j, string word, int index, int rows, int cols, bool[,] visited)
        {
            if (index == word.Length) return true;

            if (i >= rows || j >= cols || i < 0 || j < 0) return false;
            if (visited[i, j]) return false;
            if (board[i][j] != word[index]) return false;

            visited[i, j] = true;
            if (ExistFromCurrentNode(board, i + 1, j, word, index + 1, rows, cols, visited) ||
                ExistFromCurrentNode(board, i - 1, j, word, index + 1, rows, cols, visited) ||
                ExistFromCurrentNode(board, i, j - 1, word, index + 1, rows, cols, visited) ||
                ExistFromCurrentNode(board, i, j + 1, word, index + 1, rows, cols, visited))
                return true;

            else
            {
                visited[i, j] = false;
                return false;
            }

        }
    }
}