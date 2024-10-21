namespace TicTacToeUsingFacadeDP.Models
{
    public class Board
    {
        private Cell[,] _cells = new Cell[3, 3];

        public Board()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    _cells[row, col] = new Cell();
                }
            }
        }

        public void ValidateMove(int row, int col)
        {
            if (row < 0 || row > 2 || col < 0 || col > 2)
            {
                throw new InvalidMoveException("Row or column is out of range.");
            }

            if (!_cells[row, col].IsEmpty())
            {
                throw new InvalidMoveException("Cell is already filled.");
            }
        }

        public void MakeMove(int row, int col, MarkType mark)
        {
            _cells[row, col].Mark = mark;
        }

        public void DisplayBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(_cells[row, col].Mark == MarkType.Empty ? "-" : _cells[row, col].Mark.ToString());
                    if (col < 2) Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }

        public Cell[,] GetCells()
        {
            return _cells;
        }
    }



}
