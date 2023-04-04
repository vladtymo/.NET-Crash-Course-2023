
namespace ExamMineSweaper
{
    class Game
    {
        private int rows;
        private int cols;
        private int mines;
        private Cell[,] board;
        private bool gameOver;

        public Game(int rows, int cols, int mines)
        {
            this.rows = rows;
            this.cols = cols;
            this.mines = mines;
            this.board = new Cell[rows, cols];
            this.gameOver = false;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    this.board[i, j] = new Cell();
                }
            }

            Random random = new Random();
            int count = 0;
            while (count < mines)
            {
                int i = random.Next(rows);
                int j = random.Next(cols);
                if (!this.board[i, j].IsMine)
                {
                    this.board[i, j].IsMine = true;
                    count++;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    this.board[i, j].Neighbors = CountNeighbors(i, j);
                }
            }
        }

        private int CountNeighbors(int row, int col)
        {
            int count = 0;
            for (int i = Math.Max(0, row - 1); i <= Math.Min(rows - 1, row + 1); i++)
            {
                for (int j = Math.Max(0, col - 1); j <= Math.Min(cols - 1, col + 1); j++)
                {
                    if (this.board[i, j].IsMine)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private void DisplayBoard()
        {
            Console.Clear();
            Console.WriteLine("Minesweeper\n");
            Console.Write("  ");
            for (int j = 0; j < cols; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < rows; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(board[i, j].DisplayCharacter + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private bool CheckForWin()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (!board[i, j].IsMine && !board[i, j].IsRevealed)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void ProcessMove(int row, int col)
        {
            Cell cell = board[row, col];

            if (cell.IsRevealed)
            {
                return;
            }

            if (cell.IsMine)
            {
                gameOver = true;
                cell.IsRevealed = true;
                return;
            }

            cell.IsRevealed = true;

            if (cell.Neighbors == 0)
            {
                for (int i = Math.Max(0, row - 1); i <= Math.Min(rows - 1, row + 1); i++)
                {
                    for (int j = Math.Max(0, col - 1); j <= Math.Min(cols - 1, col + 1); j++)
                    {
                        ProcessMove(i, j);
                    }
                }
            }
        }

        public void Start()
        {
            while (!gameOver)
            {
                DisplayBoard();

                Console.WriteLine("Enter row and column (e.g. 0 1):");
                string[] input = Console.ReadLine().Split();

                if (input.Length != 2 || !int.TryParse(input[0], out int row) || !int.TryParse(input[1], out int col))
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }

                if (row < 0 || row >= rows || col < 0 || col >= cols)
                {
                    Console.WriteLine("Invalid row or column. Please try again.");
                    continue;
                }

                ProcessMove(row, col);

                if (CheckForWin())
                {
                    Console.WriteLine("You win!");
                    gameOver = true;
                }
            }

            DisplayBoard();
            Console.WriteLine("Game over.");
        }
    }
}
