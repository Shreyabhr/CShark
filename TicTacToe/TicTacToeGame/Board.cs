using System.Collections.Generic;

namespace TicTacToeGame
{
    public class Board
    {
        private List<Cell> _board;
        private int _size;

        public Board(int size)
        {
            _size = size;
            _board = new List<Cell>();
            for(int i = 0; i < size * size; i++)
            {
                _board.Add(new Cell());
            }
        }

        public int GetBoardSize()
        {
            return _size;
        }

        public List<Cell> GetBoard()
        {
            return _board;
        }

        public void MarkCell(int index, Mark mark)
        {
            _board[index].SetMark(mark);
        }

        public bool CheckIfBoardIsFull()
        {
            foreach(Cell cell in _board)
            {
                if(cell.GetMark() == Mark.EMPTY)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
