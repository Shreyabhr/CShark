
namespace TicTacToeGame
{
    public class Player
    {
        private Mark _mark;
        private string _name;
        public Player(string name, Mark mark)
        {
            _name = name;
            _mark = mark;
        }

        public Mark GetMark()
        {
            return _mark;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
