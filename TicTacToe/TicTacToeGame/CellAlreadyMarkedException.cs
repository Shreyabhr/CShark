using System;

namespace TicTacToeGame
{
    public class CellAlreadyMarkedException : Exception
    {
        public CellAlreadyMarkedException(string msg) : base(msg) {   }
    }
}
