namespace TicTacToeGame
{
    public class Cell
    {
        private Mark _mark;

        public Cell()
        {
            _mark = Mark.EMPTY;              
        }

        public Mark GetMark()
        {
            return _mark;
        }

        public void SetMark(Mark mark)
        {
            if(_mark == Mark.EMPTY)
            {
                _mark = mark;
                return;
            }
            throw new CellAlreadyMarkedException("Cell is already marked");
        }

    }
}
