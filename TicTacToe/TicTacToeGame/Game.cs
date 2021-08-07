using System.Collections.Generic;
using System.Linq;

namespace TicTacToeGame
{
    public class Game
    {
        private List<Player> _players;
        private Board _board;
        private ResultAnalyzer _resultAnalyzer;
        private Player _currentPlayer;
        private int _playCount;

        public Game(List<Player> players, Board board, ResultAnalyzer resultAnalyzer)
        {
            _players = players;
            _board = board;
            _resultAnalyzer = resultAnalyzer;
            _currentPlayer = players.ElementAt(0);
        }

        public string GetNextPlayerName()
        {
            if(_currentPlayer == _players.ElementAt(0))
            {
                return _players.ElementAt(0).GetName();
            }
            return _players.ElementAt(1).GetName();
        }

        public Result Play(int index)
        {
            if(_playCount > 0)
            {
                ChangePlayer();
            }
            _playCount++;
            Mark mark = _currentPlayer.GetMark();
            _board.MarkCell(index, mark);
            if(_playCount > 4)
            {
                Result result = _resultAnalyzer.GetResult(_board, mark, index);
                return result;
            }
            return Result.PROCESS;
        }

        public Player GetCurrentPlayer()
        {
            return _currentPlayer;

        }

        public void ChangePlayer()
        {
            if(GetCurrentPlayer() == _players.ElementAt(0))
            {
                _currentPlayer = _players.ElementAt(1);
                return;
            }
            _currentPlayer = _players.ElementAt(0);
        }
    }
}
