using System.Collections.Generic;
using System.Linq;

namespace TicTacToeGame
{
    public class ResultAnalyzer
    {
        private Board _board;
        public ResultAnalyzer(Board board)
        {
            _board = board;        
        }

        public bool Draw()
        {
            if (_board.CheckIfBoardIsFull())
            {
                return true;
            }
            return false;
        }

        private bool IsListEqual(List<Mark> list)
        {
            foreach(Mark mark in list){
                if (mark != list[0])
                    return false;
            }
            return true;
        }

        public bool CheckRow()
        {
            List<Mark> list = new List<Mark>();
            for(int i = 0; i < _board.GetBoardSize(); i++)
            {
                CheckRowElements(i, list);
                if (IsListEqual(list) && list[0] != Mark.EMPTY)
                    return true;
                list.Clear();
            }
            return false;
        }

        private void CheckRowElements(int i, List<Mark> list)
        {
            for(int j = 0; j < _board.GetBoardSize(); j++)
            {
                list.Add(_board.GetBoard().ElementAt((_board.GetBoardSize() * i) + j).GetMark());
            }
        }

        public bool CheckColumn()
        {
            List<Mark> list = new List<Mark>();
            for (int i = 0; i < _board.GetBoardSize(); i++)
            {
                CheckColumnElements(i, list);
                if (IsListEqual(list) && list[0] != Mark.EMPTY)
                    return true;
                list.Clear();
            }
            return false;
        }

        private void CheckColumnElements(int i, List<Mark> list)
        {
            for (int j = i; j < _board.GetBoard().Count; j = j + _board.GetBoardSize())
            {
                list.Add(_board.GetBoard().ElementAt(j).GetMark());
            }
        }

        public bool CheckUpperDiagonal()
        {
            List<Mark> list = new List<Mark>();
            for (int i = 0; i < _board.GetBoardSize(); i++)
            {
                list.Add(_board.GetBoard().ElementAt(i * _board.GetBoardSize() + i).GetMark());
                
            }
            if (IsListEqual(list) && list[0] != Mark.EMPTY)
                return true;
            return false;
        }

        public bool CheckLowerDiagonal()
        {
            List<Mark> list = new List<Mark>();
            for (int i = 1; i < _board.GetBoardSize() + 1; i++)
            {
                list.Add(_board.GetBoard().ElementAt(i * _board.GetBoardSize() - i).GetMark());               
            }
            if (IsListEqual(list) && list[0] != Mark.EMPTY)
                return true;
            return false;
        }

        public Result GetResult(Board board, Mark mark, int index)
        {
            if(CheckRow() || CheckColumn() || CheckUpperDiagonal() || CheckLowerDiagonal())
            {
                return Result.WIN;
            }
            if (Draw())
            {
                return Result.DRAW;
            }
            return Result.PROCESS;
        }
    }
}
