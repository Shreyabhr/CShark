using System;

namespace PointApp
{
    struct PointStructure
    {
        private int _x;
        private int _y;

        public PointStructure(int x, int y)
        {
            _x = x;
            _y = y;
            Console.WriteLine("me");
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public void Update(PointStructure p)
        {
            p.X = 10;
            p.Y = 11;
        }

        public void PrintDetails(PointStructure p)
        {
            Console.WriteLine(p.X + ":" + p.Y);
        }
    }
}
